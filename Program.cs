using System;

namespace Check_user_input_number_positive_or_negative
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            // Asks the user to enter a number

            Console.WriteLine("Please enter first number");
            //Below line converts the input from a string to an integer
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("Enter number is positive ");
            }

            else if (num < 0)
            {
                Console.WriteLine("Enter number is negative ");
            }


                
        }
    }
}
