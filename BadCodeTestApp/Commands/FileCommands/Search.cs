using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Search:ICommand
    {
        public virtual void execute(string path, string param)
        {
            search(path).ForEach(n => Console.WriteLine(n));
        }

        protected List<string> search(string path, string extension = "*")
        {
            return Directory.GetFiles(path, extension, SearchOption.AllDirectories).ToList();
        }
    }
    
}
