using BadCodeTestApp.Commands;
using BadCodeTestApp.Commands.FileCommands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp
{
    class Program
    {
        static Dictionary<string, ICommand> supportedCommands = new Dictionary<string, ICommand>();

        static Program()
        {
            register();
        }

        static void register()
        {
            supportedCommands.Add("search", new Search());
            supportedCommands.Add("cs_search", new SearchByExt());
        }

        static void Main(string[] args)
        {
            string command = "cs_search";
            string param     = @"D:\1dotNet\Литература";


            supportedCommands[command].execute(param, "*.cs");
            //if (command == "search")
            //{
            //    supportedCommands["search"].execute(param, string.Empty);
            //}
            //if (command == "cs_search")
            //{
            //    supportedCommands["cs_search"].execute(param, "cs");             
            //}
            //if (command == "create_txt")
            //{
            //    File.Create(param + "\\test.txt");
            //}
            //if (command == "remove_txt")
            //{
            //    File.Delete(param + "\\test.txt");
            //}

            Console.ReadLine();
        }
    }
}
