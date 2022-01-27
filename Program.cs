using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }

            // Otherwise, the program continues executing
        }

        public static void TestAll()
        {
            bool testLoadFile = TestLoadFile.RunTest();
            Console.WriteLine($"Test LoadFile(filename): {testLoadFile}");

            bool testGetUserSelection = TestGetUserSelection.RunTest();
            Console.WriteLine($"Test GetUserSelection(options): {testGetUserSelection}");

        }

        /// <summary>
        /// Given a filename, loads the file and returns a list containing each line in that file.
        /// If the file does not exist, this method throws an exception
        /// </summary>
        /// <param name="filename">The file to load</param>
        /// <returns>The file loaded as a list of strings</returns>
        public static List<string> LoadFile(string filename)
        {
            
            // 1. Check if the file exists
            if (!File.Exists(filename))
            {
                // 2. If it does not, throw an exception
                throw new Exception($"The file {filename} does not exist.");
            }
            
            // 3. If it does, load the file into a list
            List<string> result = File.ReadAllLines(filename).ToList();

            // 4. Return the loaded list
            return result;
        }

        /// <summary>
        /// Given a list of options, prompt the user to select one of the options.
        /// If the user selects a valid option, return that option.
        /// Otherwise, prompt the user again.
        /// </summary>
        /// <param name="options">The list of options to show the user</param>
        /// <returns>The option the user selected</returns>
        public static int GetUserSelection(List<string> options)
        {
            // 1. Check if the list has at least one item
            // 2. If it doesn't, throw an exception
            // 3. Loop through the list and print each option with a number in front of it
            // 4. Get input from the user
            // 5. Check if the input is one of the options
            // 6. If it is, return the option
            // 7. Otherwise, display "Invalid option" and goto step 4
            return -1;
        }
    }
}
