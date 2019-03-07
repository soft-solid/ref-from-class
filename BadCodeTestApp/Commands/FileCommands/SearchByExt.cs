using BadCodeTestApp.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BadCodeTestApp.Commands.FileCommands
{
    class SearchByExt : ExeptionHandling
    {
        public override void CommandExecute(string[] prms)
        {
            string path = prms[1];
            string pattern = prms[2];
            searchByExt(path, pattern).ForEach(n => Console.WriteLine(n));
        }

        List<string> searchByExt(string path, string pattern)
        {
            return Directory.GetFiles(path, pattern, SearchOption.AllDirectories).ToList();
        }
    }
}
