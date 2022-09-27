using IWshRuntimeLibrary;
using System;
using System.IO;

namespace NHA_CreateShortcut{
    internal class Program{
        static void Main(string[] args){
            if(args.Length == 0){
                Environment.Exit(0);
            }else{
                var CMD = args[0].Split(',');
                string shortcutName = CMD[0];
                string shortcutPath = CMD[1];
                string Description = CMD[2];
                string ApplicationToShortcut = CMD[3];
CreateAppShortcut(shortcutName,shortcutPath, ApplicationToShortcut,Description);
            }
        }

public static void CreateAppShortcut(string shortcutName, string shortcutPath, string ApplicationToShortcut,string Description){
string shortcutLocation =Path.Combine(shortcutPath, shortcutName + ".lnk");

if(System.IO.File.Exists(shortcutLocation))
System.IO.File.Delete(shortcutLocation);

WshShell shell = new WshShell();
IWshShortcut shortcut = ((IWshShortcut)shell.CreateShortcut(shortcutLocation));
shortcut.Description = Description;// The description of the shortcut
shortcut.IconLocation = ApplicationToShortcut;// The icon of the shortcut
shortcut.TargetPath = ApplicationToShortcut;// The path of the file that will launch when the shortcut is run
shortcut.Save();// Save the shortcut
}


    }
}
