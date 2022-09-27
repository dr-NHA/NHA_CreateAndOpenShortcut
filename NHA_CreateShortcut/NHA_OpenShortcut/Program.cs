using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace NHA_OpenShortcut{
    internal class Program{
        static void Main(string[] args){
            if(args.Length == 0){
                Environment.Exit(0);
            }else{
                var CMD = args[0].Split(',');
                string Directory = CMD[0];
                string Name = CMD[1];
                var CommandFile = Name + ".cmd";
                if(File.Exists(CommandFile))
                    File.Delete(CommandFile);

                File.WriteAllText(CommandFile, 
                    "cd /d \""+ Directory + "\"\n" +
                    "\""+Name+".lnk\"" 
                  //  +"\n" +"pause"
                    );

                Process P = new Process() { 
                    StartInfo=new ProcessStartInfo(CommandFile) { 
                    
                    }
                };
                P.Exited += (X, E) => {
                    
                    try{
                    if (File.Exists(CommandFile))
                        File.Delete(CommandFile);
                    }catch(Exception e){

                    }
                    Environment.Exit(0);
                };
                P.Start();

                Thread.Sleep(400);
                if(!P.HasExited)
                P.Kill();
                Thread.Sleep(400);
                    try{
                    if (File.Exists(CommandFile))
                        File.Delete(CommandFile);
                    }catch(Exception e){

                }
                Environment.Exit(0);

            }
        }
    }
}
