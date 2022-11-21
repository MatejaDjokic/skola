using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportske_pripreme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unosimo koliko dana traju pripreme
            int n = int.Parse(Console.ReadLine());

            // citamo liniju
            string line;
            // ponavljamo sve dok je vrednost te linije razlicita od null, tjst. nije prazna
            while((line = Console.ReadLine()) != null)
            {
                // inicijalizujemo res sa vrednoscu 0
                int res = 0;

                // u string niz str ucitavamo vrednosti iz linije
                string[] str = line.Split();
                // u vrednosti a i d stavljamo vrednosti na pozicijama 0 i 1 in str string niza
                int a = int.Parse(str[0]);
                int d = int.Parse(str[1]);

                // n puta ponavljamo
                for (int i = 0; i < n; i++)
                    // na res dodajemo zbir a i proizvod i, indeksa, i d
                    res += a + i * d;
                // taj rezultat na kraju delimo sa 1000, pretvaramo u km iz m, i zaokruzujemo na  2 decimale
                Console.WriteLine(((double)(res/1000.0)).ToString("0.00"));
            }

            Console.ReadKey();
        }
    }
}
/*
10
500 100
400 20
*/