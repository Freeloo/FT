
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
            Process cmdPromptAction = new Process();
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
            Console.Write("Ft version 0.2 \\ 19 may 2020 \n ");
            Console.Write("->Git of the project : https://github.com/Freloo/FT");
            
            while (true)
            {   if (!CmdPmode && !powershellMode)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write ("\n>>>" + Environment.UserName + "@" + Environment.MachineName + ">");
                    Console.ForegroundColor = ConsoleColor.White;
                    action = Console.ReadLine();
                    result = request(action, ref CmdPmode);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(result);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            if (CmdPmode)
                {
                    
                     
                        Console.Write("\n>>>Command prompt>");
                   

                    cmdAction = Console.ReadLine();

                    
                    {   if (cmdAction == "off")
                        {
                            CmdPmode = false;
                        }
                        else
                        {
                            if (cmdAction == "cd")
                            {
                                Console.Write(">>>cd path>");
                                cmdPromptAction.StartInfo.WorkingDirectory = (Console.ReadLine());
                            }
                            else
                            {
                                cmdPromptAction.StartInfo.FileName = ("cmd.exe");
                                cmdPromptAction.StartInfo.Arguments = ("/C" + cmdAction);

                                cmdPromptAction.Start();
                            }
                        }
                        
                    }

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
                                            result = " help : show this help \n createF : create a file or a folder \n delF : delete a file or a folder\n cmdPrompt : enable the command prompt mode \n start : start any programm or open a file with the app by default for this file. \n lockF : lock any file \n unlockF : unlock a file lock with the command \"lockF\" \n moveF: move a file or a directory\npoweroff : shutdown this computer ";
                                            break;

                                           }
                            case "help":
                                {
                                    result = " Command : help \n description : show the help \n Arguments : 1 \n argument 1 : command or ? \n Possible arguments1  : \n ? : show all commands \n any commands : show informations of command.\n any mode : show the information and the help of a mode.";
                                    break;
                                }
                            case "delF":
                                {
                                    result = " Command : delF \n description : delete any file or any directory \n arguments : 2  \n argument 1 : indicated if we want to del a file or a directory \n possible argument 1 : dir or file \n argument 2 : path of file/directory to delete \n possible argument 2 : any file/directory path ";
                                    break;
                                }
                            case "unlockF":
                                {
                                    result = " Command : unlockF \n description : unlock a file lock with de command \"lock\" \n arguments : 1 \n arguments 1 : path of the file to unlock \n possible aruments 1 : any file path";
                                    break;
                                }
                            case "lockF":
                                {
                                    result = " Command : lockF \n description : lock any file to other user that the actual can't open this file \n Arguments : 1 \n argument 1 : path of file to lock \n Possible arguments1  : any file path";
                                    break;
                                }
                            case "cmdPrompt":
                                {
                                    result = " Command : cmdPrompt \n descrition : enable the command prompt mode \n Arguments : 0";
                                    break; 
                                }
                            case "start":
                                {
                                    result = " Command : start \n description : start any programm or open any file \n arguments : 1 \n argument 1 : programm to start or file to open \n Possible arguments 1 : any programm or any file";
                                    break;
                                }
                            case "createF":
                                {
                                    result = "Command : createF \n description : create a file or a directory \n arguments : 1 \n argument 1 : indicated if we want to create a file or a directory \n possible argument 1 : dir or file  \n argument 2 : path of file \n possible argument 2 : any path file";
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
                case "poweroff":
                    {
                        Process poweroff = new Process();
                        poweroff.StartInfo.FileName = ("cmd.exe");
                        poweroff.StartInfo.Arguments = ("/C shutdown/p");
                        break;
                    }
                case "cmdPrompt":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("the command prompt mode in enable now. To disable, enter off \n to use the command cd, enter just cd and after the path. Cd command is reset between all command");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        cmdPMode = true;
                        break;
                    }
                case "createF":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(">>>dir/folder> ");
                        arg1=Console.ReadLine();
                        switch (arg1)
                        {
                            case "dir":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(">>>Path>");
                                    Directory.CreateDirectory(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                            case "file":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(">>>Path>");

                                    Console.ForegroundColor = ConsoleColor.White;
                                    File.Create(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                         
                        
                        break;
                    }
                case "delF":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(">>>dir/folder>");
                        arg1 = Console.ReadLine();
                        switch (arg1)
                        {
                            case "dir":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(">>>path>");
                                    Directory.Delete(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                            case "file":
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(">>>path>");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    File.Delete(Console.ReadLine());
                                    
                                    break;
                                }

                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        

                        break;
                    }
                    case "lockF":
                    {
                        Console.WriteLine(">>>path>");
                        File.Encrypt(Console.ReadLine());
                        break;
                    }
                
                case "unlockF":
                    {
                        Console.WriteLine(">>>path>");
                        File.Decrypt(Console.ReadLine());
                        break;
                    }
                
                case "start":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(">>>name>");
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
