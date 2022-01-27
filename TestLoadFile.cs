using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleProject
{
    class TestLoadFile
    {
        
        public static bool RunTest()
        {
            
            // Load test_scores.txt.
            
            List<string> scores = Program.LoadFile("test_scores.txt").ToList();

            // This file contains 3 lines
            if(scores.Count != 3)
            {
                Console.Error.WriteLine("The file test_scores should have 3 lines but that was not the case.");
                return false;
            }

            // The first line of the file should be "BurgerMan  192935"
            if(scores[0] != "BurgerMan  192935")
            {
                Console.Error.WriteLine("The first file should have been \"BurgerMan  192935\".");
                return false;
            }

            try
            {
                // This should produce an exception
                Program.LoadFile("NotAFile.txt");

                // If we get to this line, it means there was not an exception
                Console.Error.WriteLine("Expected an exception from loading \"NotAFile.txt\"");
                return false;
            }
            catch 
            {
                // Ignore the error
            }

            // If we made it this far, everything seems to be working so we return true.
            return true;
        }

    }
}
