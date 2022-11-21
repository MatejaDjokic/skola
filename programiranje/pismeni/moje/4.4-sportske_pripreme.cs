using System;

class Program {
    static void Main() {

        int n = int.Parse(Console.ReadLine());

        string linija;
        while ((linija = Console.ReadLine()) != null)
        {
            string[] str = linija.Split();

            int a = int.Parse(str[0]);
            int d = int.Parse(str[1]);
            
            long S = a;
            int x = a;

            for (int i = 1; i < n; i++)
            {
                x += d;
                S += x;
            }
            double Skm = S / 1000.0;
            Console.WriteLine(Skm.ToString("0.00"));
        }
    }
}

/*

{n} - broj dana priprema
ponavljanje sve dok unos reda nije prazan{null, nema vrednost}

unos niza str i njegovo indeksno mapiranje u promenljive {a} i {d}

inicijalizacija promenljivih {S} i {d} 

iteriranje n puta 
pri cemu na promenljivu {x}(sa vrednoscu a) dodajemo {d}
a na promenljivu {S}(sa vrednoscu a) dodajemo {x}(sa vrednoscu a + d)

na kraju pretravaramo vrednost od promeljive {S} u km i ispisujemo

to ponaljvamo sve dok unos nije prazan

*/