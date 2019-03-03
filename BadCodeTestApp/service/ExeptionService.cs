using BadCodeTestApp.Commands;
using System;
using System.IO;

namespace BadCodeTestApp.Service
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
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }            
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public abstract void CommandExecute(string path);
    }
}