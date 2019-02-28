using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands.FileCommands
{
    class SearchByExt:Search
    {
        public override void execute(string path, string param)
        {
            searchByExt(path, param).ForEach(n => Console.WriteLine(n));
        }

        List<string> searchByExt(string path, string ext)
        {
            return base.search(path,ext);            
        }
    }
}
