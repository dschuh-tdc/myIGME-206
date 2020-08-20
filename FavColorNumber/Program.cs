using System;

namespace FavColorNumber
{
    // Class: Program
    // Author: David Schuh
    // Purpose: Console Read/Write and Exception-handling exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Prompt the user for their favorite color and number
        //          Output their favorite color (in limited text colors) their favorite number of times
        // Restrictions: None
        static void Main(string[] args)
        {
            string color;
            string strNumber;
            int number = 0;
            bool valid = false;

            // prompt for favorite color
            Console.Write("Enter your favorite color: \t");

            // read their favorite color from the keyboard
            color = Console.ReadLine();

            // prompt for favorite number
            Console.Write("Enter your favorite number: \t");

            do
            {
                // read their favorite number from the keyboard
                strNumber = Console.ReadLine();

                try
                {
                    number = Convert.ToInt32(strNumber);
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");

                    // flag that they have not entered valid data yet, so that we stay in the loop
                    valid = false;
                }

            } while (!valid);

            // change the text color to their favorite color
            switch (color.ToLower())
            {
                // set the text color to Red
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                // set the text color to Blue
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                // set the text color to Green
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                //  if none of the above cases are met, then invert the text color (black on white)
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }


            // print their favorite color their favorite number of times
            for (int i = 0; i < number; ++i)
            {
                // using $"" causes string interpolation such that the {} within the string are compiled as discrete code blocks which can contain any expressions
                // in this case we add "!" to the color
                Console.WriteLine($"Your favorite color is {color + "!"}");

                // Two other ways to generate the same output:

                // 1. simple string concatenation (note that you do not use $ or {}):
                //      Console.WriteLine("Your favorite color is " + color + "!");

                // 2. string replacement using {} (but not $):
                //      Console.WriteLine("Your favorite color is {0}!", color);
            }

        }
    }
}
