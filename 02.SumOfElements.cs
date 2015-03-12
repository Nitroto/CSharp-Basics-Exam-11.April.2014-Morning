using System;
using System.Linq;

namespace SumOfElements
{
    class SumOfElements
    {
        static void Main()
        {
            string[] n = Console.ReadLine().Split(' ');
            long[] inNumbers = new long[n.Length];
            for (int i = 0; i < inNumbers.Length; i++)
            {
                inNumbers[i] = Int64.Parse(n[i]);
            }
            long maxValue = inNumbers.Max();
            long sum = inNumbers.Sum();
            bool chk = false;
            if (maxValue > 0)
            {
                if (sum / maxValue == 2 && sum % maxValue == 0)
                {
                    chk = true;
                }
                if (chk)
                {
                    Console.WriteLine("Yes, sum={0}", (maxValue));
                }
                else
                {
                    long diff = Math.Abs(sum - 2 * maxValue);
                    Console.WriteLine("No, diff={0}", diff);
                }
            }
            else
            {
                Console.WriteLine("Yes, sum={0}", (maxValue));
            }
        }
    }
}
