using System;

namespace OddNumbers
{
    class OddNumbers
    {
        public int lowerBound { get; set; }
        public int upperBound { get; set; }

        public void getLowerBound(ref int lb)
        {
            Console.WriteLine("Enter an integer between 1 and 100,000:");
            lb = Convert.ToInt32(Console.ReadLine());

            while (lb < 1 || lb > 100000)
            {
                Console.WriteLine("You must enter an integer between 1 and 100,000:");
                lb = Convert.ToInt32(Console.ReadLine());
                lowerBound = lb;
            }
        }
        public void getUpperBound(ref int rb, int lb)
        {
            Console.WriteLine("Enter an integer between 1 and 100,000 and greater than the lower bound:");
            rb = Convert.ToInt32(Console.ReadLine());

            while (rb < lb || rb > 100000)
            {
                Console.WriteLine("You must enter an integer between 1 and 100,000 and greater than the lower bound:");
                rb = Convert.ToInt32(Console.ReadLine());
                upperBound = rb;
            }
        }

        public void getOddNumbers(ref int[] oddNums, int lb, int rb)
        {
            int ii = 0;

            for (int i = lb; i <= rb; i++)
            {
                if (i % 2 != 0)
                {
                    oddNums[ii] = i;
                    ii++;
                }
            }
        }

        public void printOddNumbers(int[] oddNums)
        {
            foreach (int i in oddNums)
                Console.WriteLine(i);
        }
    }
}
