using System;
using System.Collections.Generic;

namespace ExampleProject
{
    class TestGetUserSelection
    {
        
        public static bool RunTest()
        {
            List<string> options = new List<string>();
            options.Add("First Option");
            options.Add("Second Option");
            options.Add("Third Option");

            Console.WriteLine("Running Get User Selection. The output should be:");
            Console.WriteLine("0. First Option");
            Console.WriteLine("1. Second Option");
            Console.WriteLine("2. Third Option");

            Console.WriteLine("Test the method by typing 4, then 0. 4 should produce a warning and 0 should return 0.");
            

            int result = Program.GetUserSelection(options);

            Console.WriteLine($"The method returned {result}.");
            Console.WriteLine("Does this method appear to be working?");

            return false;
        }

    }
}
