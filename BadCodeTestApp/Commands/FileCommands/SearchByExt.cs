using BadCodeTestApp.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BadCodeTestApp.Commands.FileCommands
{
    class SearchByExt : ExeptionService
    {
        public override void CommandExecute(string path)
        {
            searchByExt(path).ForEach(n => Console.WriteLine(n));
        }      
        
        List<string> searchByExt(string path)
        {
            return Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories).ToList();
        }
    }
}
