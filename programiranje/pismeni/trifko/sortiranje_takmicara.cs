using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortiranje_takmicara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> takmicari = new Dictionary<string, int>(n);

            for(int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split();
                takmicari.Add(str[0], int.Parse(str[1]));
            }
               
            var takmicarSort = takmicari.OrderBy(x => x.Key).OrderByDescending(x => x.Value);  

            foreach(KeyValuePair<string, int> pair in takmicarSort)
                Console.WriteLine(pair.Key + " " + pair.Value);

            Console.ReadKey();
        }
    }
}
