using System;

namespace FixMcServer_dat
{
    class Program
    {
        static void Main(string[] args)
        {
            String McPath = Environment.GetEnvironmentVariable("APPDATA") + "\\.minecraft\\";
            String McDatTmpPath = McPath + "servers.dat_tmp";
            String McDatPath = McPath + "servers.dat";

            Console.WriteLine("Are you sure? [y/N]");

            string answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                if (System.IO.File.Exists(McDatTmpPath))
                {
                    Console.WriteLine("Moving from " + McDatTmpPath + " to " + McDatPath);
                    System.IO.File.Move(McDatTmpPath, McDatPath);
                }
                else
                {
                    Console.WriteLine("The tmp file does not exist. Looking in " + McDatTmpPath);
                }
            }
            else
            {
                Console.WriteLine("You did not answer with y.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}

