using BadCodeTestApp.service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Create : ExeptionService// ICommand
    {
        //public void execute(string path)
        //{
        //    CommandExecute(path);
        //}
        public override void CommandExecute(string path)
        {
            CreateFile(path);
        }

        //DirectoryNotFoundException
        protected void CreateFile(string path)
        {
            File.Create(path + "\\test.txt");
        }
    }
}
