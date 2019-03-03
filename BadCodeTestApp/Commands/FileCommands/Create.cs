using BadCodeTestApp.Service;
using System.IO;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Create : ExeptionService
    {       
        public override void CommandExecute(string path)
        {
            CreateFile(path);
        }
                
        protected void CreateFile(string path)
        {
            File.Create(path + "\\test.txt");
        }
    }
}
