using System;

namespace WorkHours
{
    class WorkHours
    {
        static void Main()
        {
            int h = Int32.Parse(Console.ReadLine());
            int d = Int32.Parse(Console.ReadLine());
            int p = Int32.Parse(Console.ReadLine());
            double effectivWorkHours = (d * 0.90)*12*p/100.0;
            if ((int)effectivWorkHours >= h)
            {
                Console.WriteLine("Yes");
                Console.WriteLine((int)effectivWorkHours - h);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine((int)effectivWorkHours - h);
            }

        }
    }
}
