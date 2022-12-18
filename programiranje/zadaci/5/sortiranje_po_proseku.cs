using System;
using System.Linq;

class Program
{
    // uctivanje matrice
    static int[][] ucitaj()
    {
        // citamo liniju inputa
        string[] str = Console.ReadLine().Split();
        
        int brojUcenika = int.Parse(str[0]);
        int brojOcena = int.Parse(str[1]);

        int[][] ocene = new int[brojUcenika][];
        
        for (int u = 0; u < brojUcenika; u++)
        {
            ocene[u] = new int[brojOcena];

            str = Console.ReadLine().Split();
            
            for (int o = 0; o < brojOcena; o++)
                ocene[u][o] = int.Parse(str[o]);
        }
        return ocene;
    }
    
    static void ispisi(int[][] ocene)
    {
        for (int u = 0; u < ocene.Length; u++)
        {
            for (int o = 0; o < ocene[u].Length; o++)
                Console.Write(ocene[u][o] + " ");
            Console.WriteLine();
        }
    }
    
    static int[][] sortiraj(int[][] ocene)
    {
        // sortiramo ucenike na osnovu poslednje vrednosti u nizu
        // njihovih ocena - to je upravo dodati zbir
        return ocene.OrderByDescending(ucenik => ucenik.Sum()).ToArray();
    }
    
    static void Main()
    {
        int[][] ocene = ucitaj();
        ocene = sortiraj(ocene);
        ispisi(ocene);
    }
}