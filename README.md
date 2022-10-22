# ICSM_Plugins

##LICENCE
check licence file before sharing or incorporate it. 
Do not forget to credit source and binaries when using/importing it.

Thoses plugins are given "AS IS" and no warranty is provided. 
However, help and advicement is provided.

##Collaboration through ICS Manager community
Feel free to contribute. Wiki, Readme.md, push request, bug report and feature request are welcomed.

##Features

###Plugin Vanilla

This plugin MUST NOT alter database structures. 
You will find only tools that does not requires database alteration.

Contains :
- smart copy (copy-paste data of a selection of fields from a specific record to any records of the same table)
- Json file export
- Converter of microwaves records to Other Terrestrial Stations (for instance, to move data that should not have been in MICROWA)
- Frequencies tools : swap Tx/Rx freqs, Set Tx/Rx freqs to Half-Duplex (Tx and Rx will be set to the same value if one of them is null)
- Search for potentiel interferer (still Work In Progress) from ALL_TXRX_FREQ view
- Attached documents tools (checkers, opening, dir opening)
- Compare RR_Notes

Nota : some feature needs to be activated using the menu User Configuration.
Nota2 : Some stuff are not yet ready to be used or tested. 
You can still activate them using the "Test and demo" option in User configuration menu.

###Plugin MiscTools

This plugin WILL alter database structures. 

Contains : 
- A Query, Query customization and custom expression table that make easier to share and archive queries
- A Translations table and tools that provide an easy way to update language files for ICSM Translations
Nota : Anyone can fork this part to use any Translation API