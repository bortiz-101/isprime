using System;
using Utils;

namespace isprime
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var prime = new Prime();
            
            Console.WriteLine("Enter a number to check if it is prime:");
            
            while (true)
            { 
                Console.Write("> ");
                // Read user input
                string input = Console.ReadLine();

                
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please enter a valid integer.");
                    continue;
                }

                // Handle non-integer input
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }
                
                // Check if the number is prime
                Console.WriteLine(prime.IsPrime(number)
                    ? $"{number} is a prime number."
                    : $"{number} is not a prime number.");

                Console.WriteLine("Enter another number to check, or press Ctrl+C to exit.");
            }
        }
    }
}
