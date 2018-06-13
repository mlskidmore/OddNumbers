using System;

namespace OddNumbers
{
    class Program
    {
        // Given a lower and upper bound, find all odd numbers and return in an array
        static void Main(string[] args)
        {
            int lowerBound = 0, upperBound = 0;

            OddNumbers on = new OddNumbers();

            try
            {
                // Get lower and upper bounds from the user
                on.getLowerBound(ref lowerBound);
                on.getUpperBound(ref upperBound, lowerBound);

                Console.WriteLine("Lower bound: " + lowerBound);
                Console.WriteLine("Upper bound: " + upperBound);

                // Get array length
                int arraySize = on.getOddNumberCount(lowerBound, upperBound);

                // Declare array to hold only odd numbers
                int[] oddNumbers = new int[arraySize];

                // Get the odd numbers
                on.getOddNumbers(ref oddNumbers, lowerBound, upperBound);

                // Print odd numbers
                on.printOddNumbers(oddNumbers);

                Console.WriteLine("Lower bound: " + on.lowerBound);
                Console.WriteLine("Upper bound: " + on.upperBound);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("You must enter an integer between 1 and 100,000: " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
