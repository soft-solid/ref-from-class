using BadCodeTestApp.Service;
using System.IO;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Delete : ExeptionService
    {
        public override void CommandExecute(string path)
        {
            DeleteFile(path);
        }

        protected void DeleteFile(string path)
        {
            File.Delete(path + "\\test.txt");
        }
    }
}
