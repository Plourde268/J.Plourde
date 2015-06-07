using System;
using System.Collections.Generic;
//using a new system, system IO
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextWhileProject
{
    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            while(line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            myReader.Close();

            }
           catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Couldn't find the file. Are you sure the Directory exists?");
            }
           catch(FileNotFoundException)
            {
                Console.WriteLine("Couldn't find the file. Are you sure you're looking for the correct file?");
            }
           catch (Exception e)
            {
                Console.WriteLine("Something went wrong {0}", e.Message);
            }
        finally
        {
            //Not sure why the fuck BOB decided to throw this in here but he says 
            //this is where you wrap it up and clean it up from here
            //maybe just used to signal the end of the try/catch
        }
            Console.ReadLine();

        }
    }
}
