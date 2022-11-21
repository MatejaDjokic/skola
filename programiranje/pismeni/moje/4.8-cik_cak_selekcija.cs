using System;

public class CikCakSelekcija {
    static void Main(string[] args) {
        // ucitavamo elemente niza
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());
        
        // sortiramo ceo niz neopadajuce
        Array.Sort(a);
        
        // drugi niz u koji cemo upisati resenje
        int[] b = new int[n];
        // pozicije na koje u nizu b postavljamo elemente sa leve
        // strane i sa desne strane
        int l = 0, d = n-1;
        // obradjujemo sve elemente niza a
        for (int i = 0; i < n; i++) {
            if (i % 2 == 0)
                // one sa parnih pozicija stavljamo na pocetak niza b
                b[l++] = a[i];
            else
                // a one sa neparnih pozicija stavljamo na kraj niza b
                b[d--] = a[i];
        }
        
        Console.WriteLine(" ----------------------------- ");
        // stampamo sadrzaj niza b
        for (int i = 0; i < n; i++)
            Console.WriteLine(b[i]);
    }
}

/*
7
-3
7
1
8
-5
2
9
*/