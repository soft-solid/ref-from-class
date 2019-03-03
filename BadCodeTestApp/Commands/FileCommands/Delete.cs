using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Delete : ICommand
    {
        public void execute(string path)
        {
            DeleteFile(path);
        }

        protected void DeleteFile(string path)
        {
            File.Delete(path + "\\test.txt");
        }
    }
}
