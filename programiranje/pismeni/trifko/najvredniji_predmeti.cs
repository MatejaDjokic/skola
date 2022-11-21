using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace najvredniji_predmeti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // unosimo iznos novca 
            double iznosNovca = double.Parse(Console.ReadLine());
            // unosimo broj elemenata u nizu predmeti
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> predmeti = new Dictionary<string, double>(n);

            // unosimo vrednosti niza predmeti
            for (int i = 0; i < n; i++)
                predmeti.Add(Console.ReadLine(), double.Parse(Console.ReadLine()));

            // sortiramo od najveceg ka najvamenjem
            var predmetiSort = predmeti.OrderByDescending(x => x.Value);

            // inicijalizujemo stringBuilder sb
            StringBuilder sb = new StringBuilder();

            // za svaki par vrednosti string i double pair u sortiranoj listi predmeta
            foreach(KeyValuePair<string, double> pair in predmetiSort)
                // proveravamo ako je iznosi novca veci ili jednak ceni iz para
                if (iznosNovca >= pair.Value)
                {
                    // ako jeste oduzimamo cenu sa naseg balansa
                    iznosNovca -= pair.Value;
                    // i na sb stringBuilder dodajemo kod od para i njegovo cenu odma pored
                    sb.AppendLine(pair.Key + " " + (pair.Value).ToString("0.00"));
                }           

            // ako je iznos novca veci od nula a nema vise stavri koje mogu da se kupe ispisuje preostali novac
            if (iznosNovca > 0)
                sb.AppendLine(iznosNovca.ToString("0.00"));

            // ispisujemo stvari koje mogu da se kupe
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
