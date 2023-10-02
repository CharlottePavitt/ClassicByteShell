using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ClassicByteLibraryMainPackage;
using ClassicByteLibrbay;
using Newtonsoft.Json.Linq;

namespace ClassicByteShell
{
    public class RunObject
    {
        private String runtimecode = "0x2023";
        static FileInfo log = new FileInfo("./logs/runlogs.log");
        private StreamWriter loger = log.CreateText();
        static DateTime dt1 = new DateTime();
        dt1.ToString("yyyy/MM/dd HH:mm:ss.fff");　

        public RunObject(String runTimeCode , String[] args) {
            loger.WriteLine("");
            //Console.WriteLine(JsonReader());
            if (runTimeCode == runtimecode)
            {
                MainFunctions sf = new MainFunctions();
                Functions f = new Functions();
                try
                {
                    f.CommandReader(args);
                }
                catch (IndexOutOfRangeException)
                {
                    //string header = Process.GetCurrentProcess().MainModule.FileName;
                    String defaultHeader = "C:/";
                    throw new ClassicByteShellException("weizhi");
                    String header = defaultHeader;
                    while (true)
                    {
                        

                        Console.Write(@"{0}>", header);
                        String commandtree = Console.ReadLine();
                        String[] command = Regex.Split(commandtree, @"\ ");
                        //foreach (String s in command) 
                        //{
                        //    Console.WriteLine(s);
                        //}
                        if (command[0] == "cd")
                        {
                            try
                            {
                                DirectoryInfo cd_path = new DirectoryInfo(command[1]);
                                if (cd_path.Exists)
                                {
                                    header = command[1];
                                }
                                else
                                {
                                    Console.WriteLine("目录不可用:{0}", command[1]);
                                }
                            }
                            catch (IndexOutOfRangeException) { }

                        }
                        else if (command[0] == "exit")
                        {
                            return;
                        }
                        else {
                            f.CommandReader(command);
                        }
                        


                    }
                }
                catch (Exception e1) 
                {
                    Console.WriteLine(e1.ToString()); 
                }

            }
            else 
            {
                ClassicByteShellException cantFoundDllLibraryFile = new ClassicByteShellException("缺少ClassicByteApplicationApi文件,无法运行此程序,请尝试重新安装此程序");
            }
        }
        private void JsonReader(String json_path) {
            File.ReadAllText(json_path);
        }
    }
}
