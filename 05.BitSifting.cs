using System;

namespace BitSifting
{
    class BitSifting
    {
        static void Main()
        {
            ulong numForSift = ulong.Parse(Console.ReadLine());
            byte numberOfSieves = byte.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSieves; i++)
            {
                ulong sieve = ulong.Parse(Console.ReadLine());
                ulong sifting = numForSift | sieve;
                numForSift = sifting ^ sieve;
            }
            byte count = 0;
            while (numForSift != 0)
            {
                if ((numForSift & 0x1) == 0x1) count++;
                numForSift >>= 1;
            }
            Console.WriteLine(count);
        }
    }
}

