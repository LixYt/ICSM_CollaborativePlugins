# ICSM_Plugins

## LICENCE
check licence file before sharing or incorporate it. 
Do not forget to credit source and binaries when using/importing it.

Thoses plugins are given "AS IS" and no warranty is provided. 
However, help and advicement is provided.

## Collaboration through ICS Manager community
Feel free to contribute. Wiki, Readme.md, push request, bug report and feature request are welcomed.

## Features

### PluginManager

PluginManager is like a root plugin for all plugins in this repository. It provides a complementary SDK in order to enable management of plugin on the administration side of ICS Manager. Such feature are not yet implemented into ICS Manager native SDK.

Two tables/queries are added by this plugin : XSYS_PFEATURES (Plugins features management table) and XSYS_PF_RIGHTS (Open source plugins rights). Each plugins declares it's own feature in XSYS_PFEATURES. Administrator can ENABLE/DISABLE features to users and uses Task forces to set which user can use those features.
Feature to Taskforces are stored into XSYS_PF_RIGHTS. 

If no taskfroce is set on a feature, then everyone can use it (if XSYS_PFEATURES.ENABLE = 1). ICS Manager DB owner can always use any declared feature.

### Plugin Vanilla

In this plugin, you will only finds tools that does not requires database structure modifications.
Feature list and details are describe into wiki pages (https://github.com/LixYt/ICSM_CollaborativePlugins/wiki).

### Plugin MiscTools

This plugin WILL alter database structures. 

Feature list and details are describe into wiki pages (https://github.com/LixYt/ICSM_CollaborativePlugins/wiki).
