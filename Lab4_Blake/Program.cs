using System;

namespace Lab4_Blake
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up while statment 
            string userContinue = "y";

            while (userContinue != "n")
            {
                //ask the user for their integer and store their input
                Console.WriteLine("Please type in an integer.");
                int userInput = Verify();

                //make the table that will sit above the outputs
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("------ | -------| -----");

                //make the for loop to cycle multiple interations depending on the input
                for (int i = 1; i <= userInput; i++)
                {
                    Console.WriteLine($"{i}\t{Square(i)}\t{Cube(i)}");
                }

                //prompt the user to see if they would like to retry
                userContinue = "";
                while (userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine("Would you like to enter another integer, Y/N ?");
                    userContinue = Console.ReadLine().ToLower();
                }

            }

        }

        // seperate method(s)  used to square & cube the users input

        //square
        public static int Square(int num1)
        {
            return num1 * num1;
        }

        //cubed
        public static int Cube(int num1)
        {
            return num1 * num1 * num1;
        }

        public static int Verify()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
              Console.WriteLine("Your input is invalid. Please try again...Loser");
        
            }
            return value;
        }
    }
}
