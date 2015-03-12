using System;

namespace TheExplorer
{
    class TheExplorer
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int middle = (n / 2 + 1);
            int outerSpaces = 1;
            int innerSpaces = 1;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == (n - 1))
                {
                    Console.Write(new string('-', middle - 1));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', middle - 1));
                    Console.WriteLine();
                    outerSpaces++;
                    //innerSpaces += 2;
                }
                else
                {
                    if (i < middle - 1)
                    {
                        Console.Write(new string('-', middle - outerSpaces));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', innerSpaces));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', middle - outerSpaces));
                        Console.WriteLine();
                        outerSpaces++;
                        innerSpaces += 2;
                    }
                    else
                    {

                        Console.Write(new string('-', middle - outerSpaces));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', innerSpaces));
                        Console.Write(new string('*', 1));
                        Console.Write(new string('-', middle - outerSpaces));
                        Console.WriteLine();
                        outerSpaces--;
                        innerSpaces -= 2;
                    }
                }

            }
        }
    }
}
