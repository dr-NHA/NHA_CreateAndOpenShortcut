--NHA_CE Create And Open Shortcut Library
NHA_CE.CAOS={};
registerLuaFunctionHighlight("NHA_CE.CAOS");
--All Code For The Executables And The Compiled Binarys Themselves Can Be Found On My Github:
--https://github.com/dr-NHA/NHA_CreateAndOpenShortcut


--Create A Shortcut Via My NHA_CreateShortcut Exec/Command File
function NHA_CE.CAOS.CreateShortcut(EXE,ShortcutDirectory,ShortcutName,ShortcutDescription)
shellExecute('Code\\NHA_CreateShortcut.exe',ShortcutName..',"'..string.sub(ShortcutDirectory,0,#ShortcutDirectory-1)..'","'..ShortcutDescription..'","'..ShortcutDirectory..EXE..'"');
end
registerLuaFunctionHighlight("NHA_CE.CAOS.CreateShortcut");


--Open A Shortcut Via My NHA_OpenShortcut Exec/Command File
function NHA_CE.CAOS.OpenShortcut(ShortcutName,ShortcutDirectory)
shellExecute('Code\\NHA_OpenShortcut.exe','"'..string.sub(ShortcutDirectory,0,#ShortcutDirectory-1)..'","'..ShortcutName..'"');
end
registerLuaFunctionHighlight("NHA_CE.CAOS.OpenShortcut");

