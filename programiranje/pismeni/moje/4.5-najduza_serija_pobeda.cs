using System.Collections.Generic;
using System.Linq;
using System;


public class NajduzaSerijaPobeda {

    public static void Main(string[] args) {
        
        int n = int.Parse(Console.ReadLine());
        
        int brojac = 0;
        
        int max = 0;
        
        for (int i = 0; i < n; i++) {
            int a = int.Parse(Console.ReadLine());

            if (a == 1) {
                brojac++;
                max = brojac;
            }
            if (a == -1)
                brojac = 0;
        }
        Console.WriteLine(max);
    }
}

/*

n - broj iteracija(brojeva koje unosimo)
brojac - promenljivo za brojanje najduzih uzastopnih
max - promenljiva za zapis najvece vrednosti brojca

iteriranje n puta 
unos a 
ako je a = 1 povecavamo brojac za 1 i zapisujemo najvecu vrednost
a ako je a = -1 onda restartujemo vrednost brojaca na 0

ispisujemo najveci niz


*/