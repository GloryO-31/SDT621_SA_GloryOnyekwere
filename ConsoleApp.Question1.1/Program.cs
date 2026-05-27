using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Question1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Title
            Console.Title = "C# Program Structure Demo";

            // 1. Display welcome message
            Console.WriteLine("Welcome to the Structure of a C# Program Demo!");

            // 2. Prompt user for input dynamically
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // 3. Greet the user dynamically matching the format exactly
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine(); // Blank line for exact layout spacing

            // 4. Display the structural explanations requested
            Console.WriteLine("Program Structure Demonstrated:");
            Console.WriteLine("1. using System : imports functionality");
            Console.WriteLine("2. namespace : organizes code");
            Console.WriteLine("3. class Program : container for code");
            Console.WriteLine("4. Main() : entry point of program");
            Console.WriteLine("5. Comments : explain logic and documentation");
            Console.WriteLine(); // Blank line for exact layout spacing

            // 5. Output
            Console.WriteLine("Program executed successfully!");

            // Keeps the console window open
            Console.WriteLine("\nPress [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
