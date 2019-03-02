using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands.FileCommands
{
    class SearchByExt : ICommand
    {
        public void execute(string path)
        {
            searchByExt(path).ForEach(n => Console.WriteLine(n));
        }

        //List<string> searchByExt(string path, string ext)
        //{
        //    return base.search(path,ext);            
        //}

        List<string> searchByExt(string path)
        {
            return Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories).ToList();
        }
    }
}
