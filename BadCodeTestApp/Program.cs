using Autofac;
using BadCodeTestApp.Service;
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
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No parameters specified.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            IContainer container = ContainerIoC.GetContainerIoC();
            
            string command = args[0];
            Object obj;
            try
            {
                container.TryResolveNamed(command, typeof(ICommand), out obj);
                ICommand ins = obj as ICommand;
                ins.execute(args);
            }
            catch
            {
                Console.WriteLine("Illegal command - {0}.", command);
            }
            //c# 6.0 
            //finally
            //{
            //    ICommand ins = obj as ICommand;
            //    ins?.execute(args);
            //}

            Console.ReadLine();
        }
    }
}
