
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;




namespace FT
{
   
    class Program
    {
        

        static void Main(string[] args)
        {
        ;
            bool CmdPmode = false;
            bool powershellMode = false;
            string result = null;
            string action = null;
            string cmdAction = null;
            //start
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("FFFFFFFFFFFFFFFFFFFF     TTTTTTTTTTTTTTTTT");
            Console.WriteLine("FFFFFFFFFFFFFFFFFFFF     TTTTTTTTTTTTTTTTT");
            Console.WriteLine("FFFFF                          TTTTT");
            Console.WriteLine("FFFFF                          TTTTT");
            Console.WriteLine("FFFFF                          TTTTT");
            Console.WriteLine("FFFFF                          TTTTT");
            Console.WriteLine("FFFFFFFFFFFFF                  TTTTT");
            Console.WriteLine("FFFFFFFFFFFFF                  TTTTT");
            Console.WriteLine("FFFFF                          TTTTT");
            Console.WriteLine("FFFFF                          TTTTT");
            Console.WriteLine("FFFFF                          TTTTT");
            Console.WriteLine("FFFFF                          TTTTT\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("->press any key to continue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
            Console.Clear();
            Console.Write("Ft version 0.3 \\ 19 may 2020 \n ");
            Console.Write("->Git of the project : https://github.com/Freloo/FT");
            
            while (true)
            {   
            if (CmdPmode)
                {
           
                            Process cmd = new Process();
                                cmd.StartInfo.FileName = "cmd.exe";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(">>>command prompt>");
                            Console.ForegroundColor = ConsoleColor.White;
                            cmd.StartInfo.Arguments = "/C" + Console.ReadLine();
                                cmd.StartInfo.RedirectStandardInput = true;
                                cmd.StartInfo.RedirectStandardOutput = true;
                                cmd.StartInfo.CreateNoWindow = true;
                                cmd.StartInfo.UseShellExecute = false;
                                cmd.Start();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(cmd.StandardOutput.ReadToEnd());
                            Console.ForegroundColor = ConsoleColor.White;
                            if (cmd.StartInfo.Arguments == "/Coff")
                            {
                                CmdPmode = false;
                            }
                       }
            else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n>>>" + Environment.UserName + "@" + Environment.MachineName + ">");
                    Console.ForegroundColor = ConsoleColor.White;
                    action = Console.ReadLine();
                    result = request(action, ref CmdPmode);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(result);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            

        }

        
        static string request (string request, ref bool cmdPMode)
        { 
            string arg1 = null;
            string result = null;
            switch (request)
            {
                case "help":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">>>Command name (? for know all the possible command)> ");
                        Console.ForegroundColor = ConsoleColor.White;
                        arg1 = Console.ReadLine();
                                switch (arg1)
                                {
                                    case "?":
                                           {
                                            result = "help : show this help \ncreate : create a file or a folder \ndel : delete a file or a folder\ncmdPrompt : enable the command prompt mode \nstart : start any programm or open a file with the app by default for this file. \nlock : lock any file \nunlock : unlock a file lock with the command \"lock\"\npoweroff : shutdown the local computer\nreboot : reboot the local computer\nlogout : logout the current user\nstop : close an application\nopen : show the content of any file ";
                                            break;

                                           }
                            case "help":
                                {
                                    result = "Command : help \ndescription : show the help \nArguments : 1 \nargument 1 : command or ? \nPossible arguments1  :  \n- ? : show all commands \nany commands : show informations of command.";
                                    break;
                                }
                            case "open":
                                {
                                result = "Command : openF \nDescription : show the content of any file\narguments : 1\nargument 1 : file to open\npossible argument 1 : any file path";
                                    break;
                                }
                            
                            case "stop":
                                {
                                    result = "Command : stop\ndescription : stop any application\narguments : 1\nargument 1 : application to stop\npossible argument 1 : any application";
                                    break;
                                }
                            case "del":
                                {
                                    result = " Command : delF \ndescription : delete any file or any directory \n arguments : 2  \nargument 1 : indicated if we want to del a file or a directory \npossible argument 1 : dir or file \nargument 2 : path of file/directory to delete \npossible argument 2 : any file/directory path ";
                                    break;
                                }
                            case "unlock":
                                {
                                    result = "Command : unlockF\ndescription : unlock a file lock with de command \"lock\" \narguments : 1 \narguments 1 : path of the file to unlock \npossible aruments 1 : any file path";
                                    break;
                                }
                            case "lock":
                                {
                                    result = " Command : lockF \ndescription : lock any file to other user that the actual can't open this file \nArguments : 1 \nargument 1 : path of file to lock \nPossible arguments1  : any file path";
                                    break;
                                }
                            case "poweroff":
                                {

                                    result = "Command : poweroff \ndescription : shutdown the local computer\narguments : 0";
                                    break;
                                }
                            case "reboot":
                                {
                                    result = "Command : reboot \ndescription : reboot the local computer\narguments : 0";
                                    break;
                                }
                            case "logout":
                                {
                                    result = "Command : logout\ndescription : logout the current user\narguments : 0";
                                    break;
                                }
                            case "cmdPrompt":
                                {
                                    result = " Command : cmdPrompt \ndescrition : enable the command prompt mode \nArguments : 0";
                                    break; 
                                }
                            case "start":
                                {
                                    result = " Command : start \ndescription : start any programm or open any file \narguments : 1 \nargument 1 : programm to start or file to open \nPossible arguments 1 : any programm or any file";
                                    break;
                                }
                            case "create":
                                {
                                    result = "Command : createF \ndescription : create a file or a directory \narguments : 1 \nargument 1 : indicated if we want to create a file or a directory \npossible argument 1 : dir or file  \nargument 2 : path of file \npossible argument 2 : any path file";
                                    break;
                                }

                           
                            default:
                                {
                                    result = "Command not found";
                                    break;
                                }
                        }

                        break;
                    }
                case "stop":
                    {
                        string toostop = Console.ReadLine();
                        Process stop = new Process();

                        stop.StartInfo.Arguments = ("/C taskkill /im " + toostop);
                        stop.StartInfo.FileName = ("cmd.exe");
                        stop.Start();
                        break;

                    }
                
                case "poweroff":
                    {
                        Process poweroff = new Process();
                        poweroff.StartInfo.FileName = ("cmd.exe");
                        poweroff.StartInfo.Arguments = ("/C shutdown/p");
                        poweroff.Start();
                        break;
                    }
                case "reboot":
                    {
                        Process reboot = new Process();
                       reboot.StartInfo.FileName = ("cmd.exe");
                        reboot.StartInfo.Arguments = ("/C shutdown/l");
                        reboot.Start();
                        break;
                    }
                case "logout":
                    {
                        Process logout = new Process();
                        logout.StartInfo.FileName = ("cmd.exe");
                        logout.StartInfo.Arguments = ("/C shutdown/");
                        logout.Start();
                        break;
                    }
                case "cmdPrompt":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(">>>Enter off to disable>");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        cmdPMode = true;
                        break;
                    }
                case "open":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">>>path>");
                        Console.ForegroundColor = ConsoleColor.White;
                        string content = File.ReadAllText(Console.ReadLine());
                        Console.Write(content);
                        break;
                    }
                case "create":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">>>dir/file> ");
                        arg1=Console.ReadLine();
                        switch (arg1)
                        {
                            case "dir":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(">>>Path>");
                                    Directory.CreateDirectory(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                            case "file":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(">>>Path>");

                                    Console.ForegroundColor = ConsoleColor.White;
                                    File.Create(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                         
                        
                        break; 
                    }

                case "write":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">>>Path>");
                        string file = Console.ReadLine();
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("WriteF " + file + "\nEnter the new content");
                        Console.Write("\tACTUAL CONTENT :");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(File.ReadAllText(file));
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        File.WriteAllText(file,Console.ReadLine());
                        break;
                    }
                case "del":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">>>dir/file>");
                        arg1 = Console.ReadLine();
                        switch (arg1)
                        {
                            case "dir":
                                {
                                    
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(">>>path>");
                                    Directory.Delete(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                            case "file":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(">>>path>");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    File.Delete(Console.ReadLine());
                                    
                                    break;
                                }

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        

                        break;
                    }
                    case "lock":
                    {
                        Console.Write(">>>path>");
                        File.Encrypt(Console.ReadLine());
                        break;
                    }
                
                case "unlock":
                    {
                        Console.Write(">>>path>");
                        File.Decrypt(Console.ReadLine());
                        break;
                    }
                
                case "start":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(">>>name>");
                        Console.ForegroundColor = ConsoleColor.White;
                        string appName = Console.ReadLine();
                        Process start = new Process();
                        start.StartInfo.FileName = (appName);
                        start.Start();
                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        result = "Command not found";
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

            }
            return ">>>"+result+">";
        }

    }
}
