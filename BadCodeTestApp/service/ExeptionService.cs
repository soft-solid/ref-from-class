using BadCodeTestApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.service
{
    abstract class ExeptionService : ICommand
    {
        public void execute(string path)
        {
            try
            {                
                //todo log
                CommandExecute(path);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public abstract void CommandExecute(string path);
    }
}
