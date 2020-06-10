using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Size_of_file_or_folder
{
	class Program
	{
        static ulong totalBytes = 0;
        static void Main(string[] args)
        {
            Console.Write("Introduceti calea: ");
            string cale= "";
            Console.WriteLine();
            if (args.Length > 0)
            {
                cale = args[0];
            }
            else
            {
                cale= Console.ReadLine();
            }
            Console.WriteLine();
            if (File.Exists(cale))
            {
                ProcessFile(cale);
            }
            else if (Directory.Exists(cale))
            {
                ProcessDirectory(cale);
            }
            else
            {
                Console.WriteLine("{0} fisier sau director invalid.",cale);
            }
            Console.WriteLine();
            Console.WriteLine($"Dimensiunea totala \"{cale}\" este {totalBytes} bytes ({totalBytes / 1024f} KB)");
            Console.ReadLine();
        } 
        public static void ProcessFile(string cale)
        {
            totalBytes += (ulong)File.ReadAllBytes(cale).Length;
            Console.WriteLine($"\"{cale}\"");
        }

        public static void ProcessDirectory(string targetDirectory)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            string[] subDirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subDirectoryEntries)
                ProcessDirectory(subdirectory);
        }

       
    }
}
