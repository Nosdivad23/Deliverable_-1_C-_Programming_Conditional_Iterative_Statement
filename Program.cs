using System;
namespace Deliverable__1_C__Programming_Conditional_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an integer number between 1 and 100: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Please use an integer number");
                    Console.ReadKey(true);
                }
                
                if (input >= 0 && input <= 100) 
                {
                    break;
                }
            }
     

            Console.WriteLine("Specify the series type: Even or Odd ");
            string series = Console.ReadLine();

            if (series == "Odd")
            {
                Console.WriteLine("You have selected the " + series + " series The numbers between 0 and " + input + " are:");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected the " + series + " series The numbers between 0 and " + input + " are:");
                for (int i = 0; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}