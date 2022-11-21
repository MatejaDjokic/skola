using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace broj_deljivih_u_intervalu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int res = 0;
            for (int i = a - 1; i <= b; i++)
                if (i % k == 0)
                    res++;

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
