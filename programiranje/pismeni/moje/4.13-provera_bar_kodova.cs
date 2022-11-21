using System;

class Program
{
    // funkcija proverava da li se u intervalu [l, d] nalazi element x
    static bool sadrzi(int[] a, int l, int d, int x)
    {
        // prazan interval ne sadrzi element x
        if (l > d)
            return false;

        // nalazimo sredinu intervala
        int s = l + (d - l) / 2;

        // ako je x manji od srednjeg on se moze nalaziti samo u intevalu
        // [a, s-1] (jer je niz sortiran)
        if (x < a[s])
            return sadrzi(a, l, s - 1, x);
        // ako je x veci od srednjeg on se moze nalaziti samo u intevalu
        // [s+1, d] (jer je niz sortiran)
        else if (x > a[s])
            return sadrzi(a, s + 1, d, x);
        else
            // nasli smo element x na poziciji s
            return true;
    }
    
    // funkcija proverava da li se u datom sortiranom nizu a
    // duzine n nalazi element x
    static bool sadrzi(int[] a, int x)
    {
        return sadrzi(a, 0, a.Length - 1, x);
    }
    
    static void Main()
    {
        // ucitavamo niz
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        string[] str = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(str[i]);
        // broj onih koji postoje u nizu
        int broj = 0;
        // ucitavamo broj po broj do kraja ulaza
        string s;
        while ((s = Console.ReadLine()) != null) {
            int x = int.Parse(s);
            // ako je broj sadrzan u nizu, uvecavamo brojac
            if (sadrzi(a, x))
                broj++;
        }
        // ispisujemo rezultat
        Console.WriteLine(broj);
    }
}

/*
5
1 3 5 6 7
2
3
4
5
8
*/