using BadCodeTestApp.Service;
using System.IO;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Delete : ExeptionService
    {
        public override void CommandExecute(string[] prms)
        {
            DeleteFile(prms[1]);
        }

        protected void DeleteFile(string path)
        {
            File.Delete(path + "\\test.txt");
        }
    }
}
