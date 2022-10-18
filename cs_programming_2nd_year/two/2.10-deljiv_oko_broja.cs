using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int l = n; 
            while(l != 0)
            {
                if (l % k == 0)
                    break;
                l--;
            }
            Console.WriteLine(l);

            int d = n; 
            while(d != 0)
            {
                if (d % k == 0)
                    break;
                d++;
            }
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}