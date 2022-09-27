# NHA_CreateAndOpenShortcut
Command Based For Easy Extension With Other Scripting Languages

## 2 Projects For Both Tasks (I Made This For Some Games That Dont Like Being Opened Directly (But It Wont Work For All Btw))



## Cheat Engine LUA (CREATE SHORTCUT):

local GameDir="c:\\Game\\GameName\\";
local GameExe="ThisExe.exe";
local ShortcutName="OpenGame";
local ShortcutDescription="Open The Game Via This Shortcut";

shellExecute('NHA_CreateShortcut.exe',ShortcutName..',"'..string.sub(GameDir,0,#GameDir-1)..'","'..ShortcutDescription..'","'..GameDir..GameExe..'"');



## Cheat Engine LUA (OPEN SHORTCUT):

local ShortcutName="OpenGame";
local GameDir="c:\\Game\\GameName\\";

--Open The Shortcut
shellExecute('NHA_OpenShortcut.exe','"'..string.sub(GameDir,0,#GameDir-1)..'","'..ShortcutName..'"');

