
function ImMap(idmap) {
    var losm= new ol.layer.Tile({
        source: new ol.source.OSM()
    });
    this.layerOSM= [losm];
    this.allLayers=[this.layerOSM];
    this.map = new ol.Map({
        target: idmap,
        layers: [ losm ],
        view: new ol.View({
            center: ol.proj.fromLonLat([external.StartLongi, external.StartLati]),
            zoom: external.StartZoom
        })
    });
    this.vectorLayers = {};
    //this.kmlFil = "";
    //this.kmlLayer = null;
    this.kmlFilesVer = -1;
    this.kmlLayers = {}; //{ path:layer,..}

    this.view = this.map.getView();
    window.setTimeout(timeoutRefresh, 300);
    var vp = this.map.getViewport();
    vp.addEventListener('mousemove', mouseMove,false);
    vp.addEventListener('mouseout', mouseOut, false); //function (evt) { console.info('out'); }, false);

    this.map.on('pointermove', function (evt) {
        var f= im.map.forEachFeatureAtPixel(evt.pixel, function (feature) { if (feature.getGeometry().getType()=='Point') return feature; });
        im.map.getTargetElement().style.cursor = f ? 'pointer' : ''; });
    this.map.on('click', function (evt) {
        var modif = '';
        if (evt.originalEvent.ctrlKey) modif = modif + 'ctrl,';
        if (evt.originalEvent.altKey) modif = modif + 'alt,';
        var lst = "";
        im.map.forEachFeatureAtPixel(evt.pixel, function (feature) { if (lst) lst += "|"; lst += feature.icsmKey; return false; });
        var lonlat = ol.proj.transform(evt.coordinate, 'EPSG:3857', 'EPSG:4326');
        window.setTimeout(function(){external.MapClicked(evt.pixel[0],evt.pixel[1],lonlat[0],lonlat[1],lst,modif);});
        });
    
    this.dragBox= new ol.interaction.DragBox({ condition: ol.events.condition.platformModifierKeyOnly});
    this.map.addInteraction(this.dragBox);
    this.dragBox.on('boxend', function(evt) { 
        var extent = im.dragBox.getGeometry().getExtent();
        var lbot = ol.proj.toLonLat([extent[0],extent[1]]);
        var rtop = ol.proj.toLonLat([extent[2], extent[3]]);
        var xy= im.map.getPixelFromCoordinate(evt.coordinate);
        window.setTimeout(function(){external.RectangleSelected(lbot[0],lbot[1],rtop[0],rtop[1],xy[0],xy[1]);});
        });

    //editor of features:
    this.inputmode = "";
    this.inputtype= "";
    this.editFeatures = new ol.Collection();
    var editFeatureOverlay = new ol.layer.Vector({
        source: new ol.source.Vector({ features: this.editFeatures }),
        style: new ol.style.Style({
            fill: new ol.style.Fill({ color: 'rgba(255, 255, 255, 0.2)' }),
            stroke: new ol.style.Stroke({ color: '#ffcc33', width: 2 }),
            image: new ol.style.Circle({ radius: 7, fill: new ol.style.Fill({ color: '#ffcc33' }) })
        })
    });
    editFeatureOverlay.setMap(this.map);
    this.editModify = new ol.interaction.Modify({
        features: this.editFeatures,
        // the SHIFT key must be pressed to delete vertices, so
        // that new vertices can be drawn at the same position
        // of existing vertices
        deleteCondition: function (event) {
            return ol.events.condition.shiftKeyOnly(event) &&
                ol.events.condition.singleClick(event);
            }
        });
    this.editDraw = new ol.interaction.Draw({
        features: this.editFeatures,
        type: 'Polygon'
        });
    //this.draw.on('change', function (e) { updateCsharp(); });
    this.editDraw.on('drawend', function (e) {
        im.map.removeInteraction(im.editDraw);
        im.map.addInteraction(im.editModify); //(ol.interaction.DrawEventType.DRAWEND);
        window.setTimeout(updateGeomCsharp, 0);
        });
    //modify.on('modifystart', function (e) { alert('modifystart'); });
    this.editModify.on('modifyend', function (e) { updateGeomCsharp(); });
    // map.on('click', function (e) { alert('click'); });
}


function timeoutRefresh() {
    if (external.FitRequested) { fitExtent(external.FitExtentRequested); external.FitRequested = false; }
    if (external.CenterRequested) { fitCenter(external.CenterRequestedLongi,external.CenterRequestedLati); external.CenterRequested=false; }
    if (external.CoverageName !== im.CovrgName) coverage();
    if (external.LayerCode && external.LayerCode != im.layrCode) changeLayerTo(im.layrCode = external.LayerCode);
    if (external.VectorsDirty) handleVectors();
    if (external.KmlFiles_ver !== im.kmlFilesVer) kml();
    if (external.InputType!==im.inputtype || external.InputMode!==im.inputmode) inputMode();
    if (im.inputtype=="Pg" && im.inputmode!=="Mouse" && external.InputGeomPointsJson!==im.lastInputGeomPoints) refreshGeometry();
    im.timer = window.setTimeout(timeoutRefresh, 300);
}
function inputMode() {
    var oldType = im.inputtype, oldMode = im.inputmode;
    im.inputmode = external.InputMode;
    im.inputtype = external.InputType;
    var wasM= oldType==="Pg" && oldMode==="Mouse";
    var isM= im.inputtype==="Pg" && im.inputmode==="Mouse"
    if (wasM && !isM) {
        im.map.removeInteraction(im.editDraw);
        im.map.removeInteraction(im.editModify);
        }
    if (!wasM && isM) {
        var nb= refreshGeometry();
        if (nb==0) im.map.addInteraction(im.editDraw);
        else if (nb>=3) im.map.addInteraction(im.editModify);
        //else { document.getElementById('inpText').setAttribute('checked',true); textEdit(); }
        }
    if (oldType==="Pg" && im.inputtype!=="Pg") {
        if (im.editFeatures.getLength()>0) im.editFeatures.pop();
        }
    else if (oldType!=="Pg" && im.inputtype==="Pg" && im.inputmode!=="Mouse")
        refreshGeometry();
}
function refreshGeometry() { //update inputGeometry from c# - returns nb nodes
    im.map.removeInteraction(im.editDraw);
    im.Pol4DEC= JSON.parse(external.InputGeomPointsJson);
    im.lastInputGeomPoints= external.InputGeomPointsJson;
    im.PolVw = [];
    var coo = [];
    var nb = im.Pol4DEC.length;
    for (var i = 0; i < nb; i++) {
        var c = ol.proj.fromLonLat(im.Pol4DEC[i]);
        im.PolVw.push(c);
        coo.push(c);
        }
    var poly;
    if (nb > 0) {
        if (im.editFeatures.getLength() == 0)
            im.editFeatures.push(new ol.Feature({ name: 'mypoly', geometry: (poly = new ol.geom.Polygon([coo], 'XY')) }));
        else {
            poly = im.editFeatures.item(0).getGeometry();
            poly.setCoordinates([coo], 'XY');
            }
        var sz = im.map.getSize();
        //alert(im.view.getProjection());
        var extV = im.view.calculateExtent(sz);
        if (!poly.intersectsExtent(extV))
            im.view.fit(poly, sz, {});
        }
    else if (im.editFeatures.getLength() > 0)
        im.editFeatures.pop();
    im.Coords = coo;
    return nb;
}
function updateGeomCsharp() { //update C# from last graphic change
    ///alert("im.features.getLength()=" + im.features.getLength());
    if (im.editFeatures.getLength() == 0) {
        external.InputGeomPointsJson = "";
        if (im.PolVw.length>0) { im.PolVw.length=0; im.Pol4DEC.length=0; }
    }
    else {
        var poly = im.editFeatures.item(0).getGeometry();
        var coo = poly.getCoordinates()[0];
        var ncoo = coo.length;
        var p4= [];
        for(var i=0;i<ncoo;i++) p4[i]= ol.proj.toLonLat(coo[i]);
        external.InputGeomPointsJson = JSON.stringify(p4);
        }
    external.InputGeometryChanged();
    }

function mouseMove(event) {
    var ev = ol.proj.toLonLat(im.map.getEventCoordinate(event));
    external.UpdatePosition(ev[0], ev[1]);
}
function mouseOut(event) {
    external.UpdatePosition(1e-99,1e-99);
}


function ol3Extent(ext) {
    var lbot = ol.proj.fromLonLat([ext.MinLon, ext.MinLat]);
    var rtop = ol.proj.fromLonLat([ext.MaxLon, ext.MaxLat]);
    return [lbot[0], lbot[1], rtop[0], rtop[1]];
}
function ol3Fill(stFill) { return new ol.style.Fill({ color: stFill.color }); }
function ol3Stroke(stStroke) { return new ol.style.Stroke({ color: stStroke.color, width:stStroke.width }); }
function ol3Image(stImage) {
    if (stImage.type == "circle")
        return new ol.style.Circle({ radius: stImage.radius, fill: ol3Fill(stImage.fill), stroke: ol3Stroke(stImage.stroke) });
    else {
        var out;
        switch (stImage.type) {
            case "crux":
                var symbol = [[-1, -8], [1, -8], [1, -1], [8, -1], [8, 1], [1, 1], [1, 8], [-1, 8], [-1, 1], [-8, 1], [-8, -1], [-1, -1], [-1, -8]];
                var scale;
                var scaleFunction = function (coordinate) { return [(coordinate[0] + 8) * scale, (coordinate[1] + 8) * scale]; };
                var scale = stImage.size / 16;
                var canvas = document.createElement('canvas'); //{HTMLCanvasElement} 
                var vectorContext = ol.render.toContext(canvas.getContext('2d'), { size: [stImage.size, stImage.size], pixelRatio: 1 });
                vectorContext.setStyle(new ol.style.Style({
                    fill: ol3Fill(stImage.fill),
                    stroke: ol3Stroke(stImage.stroke)
                }));
                vectorContext.drawGeometry(new ol.geom.Polygon([symbol.map(scaleFunction)]));
                out = new ol.style.Icon({
                    img: canvas,
                    imgSize: [stImage.size, stImage.size]
                });
                break;

            default:
                var pic = document.createElement("img");
                pic.src = "./Images/" + stImage.type + ".png";
                out = new ol.style.Icon({
                    img: pic,
                    imgSize: [24, 24]
                });
                break;
        }
        return out;
    }
}


// http://stackoverflow.com/questions/14484787/wrap-text-in-javascript
function stringDivider(str, width, spaceReplacer) {
    if (str.length > width) {
        var p = width;
        while (p > 0 && (str[p] != ' ' && str[p] != '-')) p--;
        if (p > 0) {
            var left;
            if (str.substring(p, p + 1) == '-')
                left = str.substring(0, p + 1);
            else left = str.substring(0, p);
            var right = str.substring(p + 1);
            return left + spaceReplacer + stringDivider(right, width, spaceReplacer);
            }
        }
    return str;
    }
function getText(feature, resolution, dom) {
    var text = feature.get('name')||'';
    if (resolution > dom.maxreso) text = '';
    else if (dom.text=='hide') text= '';
    else if (dom.text=='shorten') {var nb=12; if (text.length>nb) text= text.substr(0,nb-1)+'...'; }
    else if (dom.text=='wrap') text = stringDivider(text,16,'\n');
    return text;
    }
function ol3StyleBuilder(vlName) {
    var newFill= ol3Fill(external.VectorsGetStyleFill(vlName));
    var newStroke= ol3Stroke(external.VectorsGetStyleStroke(vlName)); 
    var newImage = ol3Image(external.VectorsGetStyleImage(vlName));
    var dom= external.VectorsGetStyleText(vlName);
    return function(feature,resolution) {
        var newText= new ol.style.Text({
            textAlign: dom.align,
            textBaseline: dom.baseline,
            font: dom.weight + ' ' + dom.size + ' ' + dom.font,
            text: getText(feature, resolution, dom),
            fill: new ol.style.Fill({color: dom.fillColor}),
            stroke: new ol.style.Stroke({color: dom.outlineColor, width: dom.outlineWidth}),
            offsetX: dom.offsetX,
            offsetY: dom.offsetY,
            rotation: dom.rotation
        });
        return new ol.style.Style({fill:newFill,stroke:newStroke,image:newImage,text:newText});
        };
    }
function handleVectors() {
    if (external.VectorsDirty) {
        external.VectorsDirty= false;
        var kkml;
        var vllst = external.GetVectorsList().split('|');
        //delete unregistered layers
        for(var x in im.vectorLayers) if (vllst.indexOf(x)== -1) {
            var olay= im.vectorLayers[x];
            delete im.vectorLayers[x];
            olay.setVisible(false);
            im.map.removeLayer(olay);
            olay.getSource().clear();
            }
        //still registered ones
        for(var x in vllst) {
            var vlName = vllst[x];
            var isDirty, isStyleDirty, isTextDirty;
            while(isDirty= external.VectorsIsDirty(vlName)) {
                isStyleDirty= isDirty && external.VectorsIsStyleDirty(vlName);
                isTextDirty= isDirty && external.VectorsIsTextDirty(vlName);
                var olay= im.vectorLayers[vlName];
                if (!olay) {
                    //new vector layer
                    olay = new ol.layer.Vector({
                        source: new ol.source.Vector() //{features: new ol.Collection() }
                    })
                    im.vectorLayers[vlName]= olay;
                    im.map.addLayer(olay);
                    olay.setVisible(true);
                    isStyleDirty= true;
                    }
                if (isStyleDirty||isTextDirty) {
                    olay.setVisible(false);
                    if (isStyleDirty) 
                        olay.setStyle(ol3StyleBuilder(vlName));
                    if (isTextDirty)
                        olay.getSource().forEachFeature( function(feature) { feature.set('name',external.VectorsGetNewName(vlName,feature.icsmKey)); return false;});
                    olay.setVisible(true);
                    }
                var keysDirty= external.VectorsGetDirtyKeys(vlName);
                if (keysDirty) {
                    var kys= keysDirty.split('|');
                    var mapkys={}; for(var ik in kys) mapkys[ kys[ik]]=true;
                    var src= olay.getSource();
                    //remove all the dirty ones
                    var features= [];
                    src.forEachFeature(function (feature) { if (mapkys[feature.icsmKey]) features.push(feature); return false; });
                    //alert("kys=" + kys + ",len=" + src.getFeatures().length + "," + features.length);
                    if (src.getFeatures().length==features.length) src.clear();
                    else for(var i=features.length-1;i>=0;i--) src.removeFeature(features[i]);
                    //alert("reste="+ src.getFeatures().length);
                    //build and append all the dirty ones
                    features= [];
                    for(var ik in kys) { var key=kys[ik]; 
                        var det= external.VectorsGetDetails(vlName,key);
                        //alert(vlName+"/"+key+".Type="+det.Type);
                        if (!det.Type) continue;
                        if (det.Type=="KML") { 
                            if (!kkml) kkml = new ol.format.KML();
                            var arrf1 = kkml.readFeatures(det.Kmldata);
                            for(var f in arrf1) {
                                var fe = arrf1[f];
                                var ge = fe.getGeometry();
                                if (ge) ge.transform('EPSG:4326', "EPSG:3857");
                                fe.icsmKey= key;
                                features.push(fe);
                                }
                            }
                        else if (det.Type=="Point") {
                            var fcg= new ol.geom.Point(ol.proj.transform([det.Longi,det.Lati],'EPSG:4326', "EPSG:3857"));
                            var fc = new ol.Feature({ name: det.Text, geometry: fcg });
                            fc.icsmKey= key;
                            features.push(fc);
                            }
                        else if (det.Type=="Circle") {
                            var fcg= ol.geom.Polygon.circular(new ol.Sphere(6378137), [det.Longi,det.Lati], det.RadiusM, 32);
                            fcg.transform('EPSG:4326', "EPSG:3857");
                            var fc = new ol.Feature({ name: det.Text, geometry: fcg });
                            fc.icsmKey= key;
                            features.push(fc);
                            }
                        else if (det.Type == "Polygon") {
                            var nb= external.VectorsGetDetailsNbPoints();
                            if (nb>=3) {
                                var coo=[];
                                for(var i=0;i<nb;i++) coo.push([external.VectorsGetDetailsNthLon(i), external.VectorsGetDetailsNthLat(i)]);
                                if (coo[nb-1][0]!=coo[0][0]||coo[nb-1][1]!=coo[0][1]) coo.push([coo[0][0],coo[0][1]]);
                                var ge= new ol.geom.Polygon([coo], 'XY');
                                if (ge) ge.transform('EPSG:4326', "EPSG:3857");
                                var fc= new ol.Feature({ name: det.Text, geometry:ge });
                                fc.icsmKey= key;
                                features.push(fc);
                                }
                            }
                        }
                    src.addFeatures(features);
                    //alert("len="+features.length+","+src.getFeatures().length);
                    }
                external.VectorsDirtyUpdated(vlName)
                }
            }
        }
    }
function kml() {
    im.kmlFilesVer = external.KmlFiles_ver;
    var reqNames = [];
    var nb = external.KmlFiles_count;
    for(var l=0;l<nb;l++) reqNames.push(external.GetIthKmlFile(l));
    var toclean = {};
    for (var l in im.kmlLayers) if (reqNames.indexOf(l)== -1) toclean[l] = im.kmlLayers[l];
    for (var l in toclean) {
        delete im.kmlLayers[l];
        var olay = toclean[l];
        olay.setVisible(false);
        im.map.removeLayer(olay);
        olay.getSource().clear();
        }
    for (var ik in reqNames) {
        var kmlfil= reqNames[ik];
        if (!im.kmlLayers[kmlfil]) {
            var olay= new ol.layer.Vector({
                source: new ol.source.Vector() //{features: new ol.Collection() }
                })
            im.kmlLayers[kmlfil]= olay;
            im.map.addLayer(olay);
            olay.setVisible(true);
            var src= olay.getSource();
            features= [];
            var kkml = new ol.format.KML();
            var arrf1 = kkml.readFeatures(external.GetKmlData(kmlfil));
            for(var f in arrf1) {
                var fe = arrf1[f];
                var ge = fe.getGeometry();
                if (ge) ge.transform('EPSG:4326', "EPSG:3857");
                features.push(fe);
                }
            src.addFeatures(features);
            }
        }
}

function bingLayer(style) {
    return new ol.layer.Tile({
        preload: Infinity,
        source: new ol.source.BingMaps({
            key: 'ArAF2mC0EyQI9-k4ty7m-zlkrRS-GBghXZE_XpWPFdF5nVgAbHHaTianlkaGFQIH', //arcep
            //MDN: "AgAuqEizNCG46goQiquz3ERCSuMYj8hr1udAEXpb1-kix08_29KzSOGQCkyL_eJc" 
            imagerySet: style
            })
        });
    }
function changeLayerTo(la) {
    var isMultimap = la.substr(0, 8) == "multimap";
    var multimapExtent;
    var layerGrp = im[la];
    //alert(typeof ol.source.KML);alert(typeof ol.format.KML);
    if (!layerGrp) {
        if (la == "layerBingRoads") layerGrp = [
            bingLayer('Road'),
            //new ol.layer.Vector({
            //    source: new ol.source.KML({
            //        projection: 'EPSG:3857',
            //        url: 'file://C:/Docs/Orgs/OFCOM/Test files/Test data/Test data/KML File/54dB.kml'
            //        })
            //    }) 
        ];
        if (la == "layerBingAerial") layerGrp = [bingLayer('Aerial')];
        if (la == "layerBingAerialLab") layerGrp = [bingLayer('AerialWithLabels')];
        if (isMultimap) { //multimap0, multimap1,...
            multimapExtent = external.OpenImage(la);
            var ext = ol3Extent(multimapExtent);
            layerGrp = im[la];
            if (layerGrp) {
                layerGrp[1].setExtent(ext);
            }
            else {
                layerGrp = [
                //new ol.layer.Tile({ source: new ol.source.OSM() }), OFCOM doesn't want it
                new ol.layer.Image({
                    extent: ext,
                    source: new ol.source.ImageWMS({
                        url: "",
                        params: { 'LAYERS': "Image" }, //'topp:states', 'TILED': true 
                        serverType: 'geoserver',
                        projection: 'EPSG:3857',
                        imageLoadFunction: function (image, src) {
                            //alert(src);
                            image.getImage().src = external.GetImage(src); //"file://C:/temp/Untitled.png";//src;
                        },
                    })
                })
                ];
            }
        }
        if (layerGrp) {
            if (!im[la]) {
                im[la] = layerGrp;
                var col = im.map.getLayers();
                for (var i in layerGrp) col.insertAt(i, layerGrp[i]); //pour que coverage, vector layers restent au dessus...
                im.allLayers.push(layerGrp);
            }
        }
    }
    else { //already created
        if (isMultimap) {
            multimapExtent= external.OpenImage(la);
            }
        }
    if (layerGrp) for (var i in im.allLayers) { var lrg = im.allLayers[i]; for (var k in lrg) lrg[k].setVisible(lrg === layerGrp); }
    if (!isMultimap) external.CloseImage();
    if (isMultimap) { fitExtent(multimapExtent); im.view.setZoom(im.view.getZoom() + 1); }
}


function fitExtent(extentJs) {
    im.view.fit(ol3Extent(extentJs), im.map.getSize(), {});
}
function fitCenter(longi, lati) { var cnt = ol.proj.fromLonLat([longi,lati]); im.view.setCenter(cnt); }

function coverage() {
    var reqName= external.CoverageName; //    var req = document.getElementById("coverage").checked;
    if (im.CovrgName==reqName) return;
    if (im.Covrg) im.Covrg.setVisible(false);
    im.CovrgName="";
    if (reqName) {
        var ext= external.GetCoverageExtent();
        var extnt= ol3Extent(ext);
        if (im.Covrg)
            im.Covrg.setExtent(extnt);
        else {
            im.Covrg = new ol.layer.Image({
                extent: extnt,
                opacity: 0.6,
                brightness: 0.2,
                source: new ol.source.ImageWMS({
                    url: "",
                    params: { 'LAYERS': "Image" },
                    serverType: 'geoserver',
                    projection: 'EPSG:3857',
                    imageLoadFunction: function (image, src) {
                        image.getImage().src = external.GetCoverage(src); //"file://C:/temp/Untitled.png";//src;
                        },
                    })
                });
            im.map.addLayer(im.Covrg);
            }
        im.CovrgName = reqName;
        im.Covrg.setVisible(true);
        }
    }