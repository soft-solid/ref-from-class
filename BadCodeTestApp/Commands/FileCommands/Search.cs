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
        public void execute(string path)
        {
            search(path).ForEach(n => Console.WriteLine(n));
        }

        protected List<string> search(string path)
        {
            return Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList();
        }
    }
    
}
