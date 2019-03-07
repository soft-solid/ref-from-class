using BadCodeTestApp.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Search : ExeptionHandling
    {
        public override void CommandExecute(string[] prms)
        {

            string path = prms[1];// нужно ли объявлять эту переменную??

            if (prms.Length > 2)// или лучше довавлять маску "*" в массив и всегда передавать 2 параметра в search()? или и то и то глупости?
            {
                search(path, prms[2]).ForEach(n => Console.WriteLine(n));
            }
            else
            {
                search(path).ForEach(n => Console.WriteLine(n));
            }
        }

        List<string> search(string path, string pattern = "*")
        {
            return Directory.GetFiles(path, pattern, SearchOption.AllDirectories).ToList();
        }

        class InfalidMask : Exception
        {
            public InfalidMask(string message)
                : base(message)
            { }
        }
    }

}
