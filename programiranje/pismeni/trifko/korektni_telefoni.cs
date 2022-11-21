using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korektni_telefoni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] brojevi = new string[n];
            for (int i = 0; i < n; i++)
                brojevi[i] = Console.ReadLine();

            bool OK = true;
            Array.Sort(brojevi);

            for(int i = 1; i < n; i++)
                if (brojevi[i].StartsWith(brojevi[i - 1]))
                {
                    OK = false;
                    break;
                }

            Console.WriteLine(OK ? "da" : "ne");
            Console.ReadKey();
        }
    }
}
