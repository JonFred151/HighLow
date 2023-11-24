using System;
using System.Timers;


namespace HighLow
{
    internal class program
    {

        public static void Main(string[] args)
        {
            // init the variable and assign 
            var r = new Random();
            var favNumber = r.Next(1, 100);

            Console.WriteLine("Guess a number");
            var userInput = int.Parse(Console.ReadLine());
            while (userInput != favNumber)
            {
               
                if (userInput > favNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too low");
                }
                Console.WriteLine("Guess a number");
                 userInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You got it right!");









           }
    }
}