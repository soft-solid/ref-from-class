using BadCodeTestApp.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Search : ExeptionService
    {
        public override void CommandExecute(string path)
        {
            search(path).ForEach(n => Console.WriteLine(n));
        }
        
        List<string> search(string path)
        {
            return Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();
        }
    }
    
}
