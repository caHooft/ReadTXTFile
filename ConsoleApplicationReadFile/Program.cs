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

            bool app = false;

            Console.WriteLine("Console TXT reader\r");
            Console.WriteLine("------------------------\n");

            while (!app)
            {

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - ReadAllText");
                Console.WriteLine("\ts - ReadTextLineByLine");
                Console.WriteLine("\td - ReadAllTextPointcloud");
                Console.WriteLine("\tf - ReadTextLineByLinePointcloud");
                Console.Write("Your option? ");

                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Your result: = ");
                        ReadAllText();
                        break;

                    case "s":
                        Console.WriteLine($"Your result: = ");
                        ReadTextLineByLine();
                        break;

                    case "d":
                        Console.WriteLine($"Your result: = ");
                        ReadAllTextPointcloud();
                        break;

                    case "f":
                        Console.WriteLine($"Your result: = ");
                        ReadTextLineByLinePointcloud();
                        break;

                    default:
                        Console.WriteLine($"please enter a,s,d or f");
                        break;
                }
                Console.Write("Press 'c' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "c") app = true;

                Console.WriteLine("\n");
            }
        }

        public static void ReadAllText()
        {
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\TestFolderTXTReader\WriteText.txt");

            // Display the file contents to the console.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }

        public static void ReadTextLineByLine()
        {
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
        }

        public static void ReadAllTextPointcloud()
        {
            // Read the LAS in TXT form as one string.
            // Crashes at this moment because of insuffiecient memory.
            string testText = System.IO.File.ReadAllText(@"C:\TestFolderTXTReader\TestRead.txt");

            // Display the file contents to the console.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", testText);
        }

        public static void ReadTextLineByLinePointcloud()
        {
            // Read each line of the file into a string array. 
            // Each element of the array is one line of the file.TestRead2
            string[] testLines = System.IO.File.ReadAllLines(@"C:\TestFolderTXTReader\TestRead.txt");

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
        }
    }
}
