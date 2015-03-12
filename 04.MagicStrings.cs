using System;

namespace MagicStrings
{
    class MagicStrings
    {
        private static int WeightCalculator(string combination)
        {
            int weight = 0;
            foreach (var character in combination)
            {
                switch (character)
                {
                    case 's':weight += 3;break;
                    case 'n':weight += 4;break;
                    case 'k': weight += 1;break;
                    case 'p':weight += 5;break;
                }
            }
            return weight;
        }
        static void Main()
        {
            int diff = Int32.Parse(Console.ReadLine());
            char[] letters = { 'k', 'n', 'p', 's' };
            int numberOfCombinations = 0;
            for (int p1 = 0; p1 < letters.Length; p1++)
            {
                for (int p2 = 0; p2 < letters.Length; p2++)
                {
                    for (int p3 = 0; p3 < letters.Length; p3++)
                    {
                        for (int p4 = 0; p4 < letters.Length; p4++)
                        {
                            string firstCombination = ""+ letters[p1]+ letters[p2]+ letters[p3]+ letters[p4];
                            int weightOfFirstComb = WeightCalculator(firstCombination);
                            for (int p5 = 0; p5 < letters.Length; p5++)
                            {
                                for (int p6 = 0; p6 < letters.Length; p6++)
                                {
                                    for (int p7 = 0; p7 < letters.Length; p7++)
                                    {
                                        for (int p8 = 0; p8 < letters.Length; p8++)
                                        {
                                            string secondCombination = "" + letters[p5] + letters[p6] + letters[p7] + letters[p8];
                                            int weightOfSecondComb = WeightCalculator(secondCombination);
                                            if (Math.Abs(weightOfFirstComb - weightOfSecondComb) == diff)
                                            {
                                                Console.WriteLine("{0}{1}", firstCombination, secondCombination);
                                                numberOfCombinations++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (numberOfCombinations == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
