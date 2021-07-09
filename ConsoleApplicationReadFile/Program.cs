using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\TestFolderTXTReader\WriteText.txt");

            // Display the file contents to the console.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Read each line of the file into a string array. 
            // Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\TestFolderTXTReader\WriteText2.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            // Stopgap between simple file -> reading LAS file
            Console.WriteLine("Press any key to continue to LAS File reading.");
            System.Console.ReadKey();

            // Read the LAS in TXT form as one string.
            // Crashes at this moment because of insuffiecient memory.
            //string testText = System.IO.File.ReadAllText(@"C:\TestFolderTXTReader\TestRead.txt");

            // Display the file contents to the console.
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", testText);

            // Read each line of the file into a string array. 
            // Each element of the array is one line of the file.TestRead2
            string[] testLines = System.IO.File.ReadAllLines(@"C:\TestFolderTXTReader\TestRead2.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of TestRead2.txt = ");
            foreach (string line in testLines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            // Any key press closes the console
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
