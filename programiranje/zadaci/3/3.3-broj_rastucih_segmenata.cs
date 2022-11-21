using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            int n, prethodni;;
            n = int.Parse(Console.ReadLine());
            
            prethodni = int.Parse(Console.ReadLine());
            long brojRastucih = 0;
            long duzinaTekuceRastuce = 1;

            for (int i = 1; i < n; i++)
            {
                int tekuci;
                tekuci = int.Parse(Console.ReadLine());

                if (tekuci > prethodni)
                    duzinaTekuceRastuce++;
                else
                {
                    brojRastucih += (duzinaTekuceRastuce - 1) * duzinaTekuceRastuce / 2;
                    duzinaTekuceRastuce = 1;
                }
                prethodni = tekuci;
            }

            brojRastucih += (duzinaTekuceRastuce - 1) * duzinaTekuceRastuce / 2;
            Console.WriteLine(brojRastucih);
        }
    }
}