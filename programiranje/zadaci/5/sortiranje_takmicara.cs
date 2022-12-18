using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    struct Takmicar
    {
        public string ime;
        public int brojPoena;
    };
    
    static bool uporedi(Takmicar A, Takmicar B)
    {
        if (A.brojPoena > B.brojPoena)
            return true;
        if (A.brojPoena < B.brojPoena)
            return false;
        return String.Compare(A.ime, B.ime) <= 0;
    }
    
    static void razmeni(ref Takmicar A, ref Takmicar B)
    {
        Takmicar P = A;
        A = B;
        B = P;
    }
    
    static void Main()
    {
        // promljive n koja oznacava broj takmicara
        int n = int.Parse(Console.ReadLine());
        
        // pravljenje promenljive a tjst. liste svih takmicara
        Takmicar[] a = new Takmicar[n];
        
        // ponavljamo n puta
        for (int i = 0; i < n; i++)
        {
            // unosimo liniju u kojoj se nalazi ime i br poena
            string[] r = Console.ReadLine().Split(' ');
            // u listu a unosimo poene i ime takmicara 
            a[i].ime = r[0];
            a[i].brojPoena = int.Parse(r[1]);
        }

        // ponavljamo jedan put manje od broja takmicara
        for (int i = 0; i < n - 1; i++)
        {
            // kazemo da je pocetni maximum jednak i tjst redni broj
            int iMax = i;
            // s ovim for loop-om prolazimo kroz svaki element 
            for (int j = i + 1; j < n; j++)
            // onda ih uporedjujemo 
                if (uporedi(a[j], a[iMax]))
                    // stavljamo da je maximalni redni broj jednak j 
                    iMax = j;
                    // razmenjujemo u listi elemente tjst sortiramo
            razmeni(ref a[iMax], ref a[i]);
        }
        
        // ispisujemo imena ih broj poena svakog takmicara
        for (int i = 0; i < n; i++)
            Console.WriteLine(a[i].ime + " " + a[i].brojPoena);
    }
}