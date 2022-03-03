using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
using System.Threading.Tasks;
using System.Drawing;
using SharpDX.DXGI;
using D3D11 = SharpDX.Direct3D11;
using SharpDX.Direct3D;
using System.Windows.Forms;
using SharpDX;
using SharpDX.D3DCompiler;

namespace XICSM.MiscTools.Module3d
{
    public class Viewer3d : IDisposable
    {
        private RenderForm renderForm;

        private const int Width = 1280;
        private const int Height = 720;
        private D3D11.Device d3d11Device;
        private D3D11.DeviceContext d3d11DeviceContext;
        private SwapChain swapChain;
        private D3D11.RenderTargetView renderTargetView;

        private Vector3[] vertices = new Vector3[] { 
            new Vector3(0.0f, -1.0f, -1.0f), new Vector3(0.0f, -1.0f, 1.0f), new Vector3(-0.1f, 1.0f, -1.0f), 
        };
        private D3D11.Buffer triangleVertexBuffer;
        private D3D11.VertexShader vertexShader;
        private D3D11.PixelShader pixelShader;
        private D3D11.InputElement[] inputElements = new D3D11.InputElement[]
            {
                new D3D11.InputElement("POSITION", 0, Format.R32G32B32_Float, 0)
            };
        private ShaderSignature inputSignature;
        private D3D11.InputLayout inputLayout;

        private Viewport viewport;

        public Viewer3d()
        {
            renderForm = new RenderForm("3D View");
            renderForm.ClientSize = new Size(Width, Height);
            renderForm.AllowUserResizing = true;
            
            InitializeDeviceResources();
            InitControls();

            InitializeShaders();
            InitializeTriangle();
        }

        public void Run()
        {
            RenderLoop.Run(renderForm, RenderCallback);
        }
        private void InitializeDeviceResources()
        {
            ModeDescription backBufferDesc = new ModeDescription(Width, Height, new Rational(60, 1), Format.R8G8B8A8_UNorm);
            SwapChainDescription swapChainDesc = new SwapChainDescription()
            {
                ModeDescription = backBufferDesc,
                SampleDescription = new SampleDescription(1, 0),
                Usage = Usage.RenderTargetOutput,
                BufferCount = 1,
                OutputHandle = renderForm.Handle,
                IsWindowed = true,
            };

            D3D11.Device.CreateWithSwapChain(DriverType.Hardware, D3D11.DeviceCreationFlags.None, swapChainDesc, out d3d11Device, out swapChain);
            d3d11DeviceContext = d3d11Device.ImmediateContext;

            using (D3D11.Texture2D backBuffer = swapChain.GetBackBuffer<D3D11.Texture2D>(0))
            {
                renderTargetView = new D3D11.RenderTargetView(d3d11Device, backBuffer);
            }

            viewport = new Viewport(30, 30, Width, Height);
            d3d11DeviceContext.Rasterizer.SetViewport(viewport);
        }
        private void InitializeTriangle()
        {
            triangleVertexBuffer = D3D11.Buffer.Create<Vector3>(d3d11Device, D3D11.BindFlags.VertexBuffer, vertices);
        }
        private void InitializeShaders()
        {
            using (var vertexShaderByteCode = ShaderBytecode.CompileFromFile("Module3d/vertexShader.hlsl", "main", "vs_4_0", ShaderFlags.Debug))
            {
                inputSignature = ShaderSignature.GetInputSignature(vertexShaderByteCode);
                vertexShader = new D3D11.VertexShader(d3d11Device, vertexShaderByteCode);
            }
            using (var pixelShaderByteCode = ShaderBytecode.CompileFromFile("Module3d/pixelShader.hlsl", "main", "ps_4_0", ShaderFlags.Debug))
            {
                pixelShader = new D3D11.PixelShader(d3d11Device, pixelShaderByteCode);
            }

            // Set as current vertex and pixel shaders
            d3d11DeviceContext.VertexShader.Set(vertexShader);
            d3d11DeviceContext.PixelShader.Set(pixelShader);

            d3d11DeviceContext.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleList; //?

            inputLayout = new D3D11.InputLayout(d3d11Device, inputSignature, inputElements);
            d3d11DeviceContext.InputAssembler.InputLayout = inputLayout;
        }
        private void RenderCallback()
        {
            Draw();
        }
        private void Draw()
        {
            d3d11DeviceContext.OutputMerger.SetRenderTargets(renderTargetView);
            d3d11DeviceContext.ClearRenderTargetView(renderTargetView, new SharpDX.Color(32, 103, 178));

            d3d11DeviceContext.InputAssembler.SetVertexBuffers(0, new D3D11.VertexBufferBinding(triangleVertexBuffer, Utilities.SizeOf<Vector3>(), 0));
            Console.WriteLine($"Contains {vertices.Count()} vertices");
            d3d11DeviceContext.Draw(vertices.Count(), 0);

            swapChain.Present(1, PresentFlags.None);
        }
        private void InitControls()
        {
            NumericUpDown nud = new NumericUpDown();
            nud.Minimum = -10;
            nud.Maximum = 10;
            nud.Name = "TestControl";
            renderForm.Controls.Add(nud);
            //nud.BringToFront();
        }
        public void Dispose()
        {
            inputLayout.Dispose();
            inputSignature.Dispose();

            triangleVertexBuffer.Dispose();
            vertexShader.Dispose();
            pixelShader.Dispose();

            renderTargetView.Dispose();
            swapChain.Dispose();
            d3d11Device.Dispose();
            d3d11DeviceContext.Dispose();
            renderForm.Dispose();
        }
    }
}
