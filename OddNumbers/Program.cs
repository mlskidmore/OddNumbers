using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 0, upperBound = 0;

            OddNumbers on = new OddNumbers();

            try
            {
                on.getLowerBound(ref lowerBound);
                on.getUpperBound(ref upperBound, lowerBound);

                Console.WriteLine("Lower bound: " + lowerBound);
                Console.WriteLine("Upper bound: " + upperBound);

                int[] oddNumbers = new int[(lowerBound + upperBound)/2];

                on.getOddNumbers(ref oddNumbers, lowerBound, upperBound);

                on.printOddNumbers(oddNumbers);

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
