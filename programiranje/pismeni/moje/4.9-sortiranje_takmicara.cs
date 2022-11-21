using System;

public class SortiranjeTakmicara {
    struct Takmicar {
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
        // broj takmicara
        int n = int.Parse(Console.ReadLine());
        // lista tipa Takmicar duzine n
        Takmicar[] a = new Takmicar[n];
        // ucitavamo podatke (ime, brojPoena) od svakog takmicara u listu a
        for (int i = 0; i < n; i++)
        {
            string[] r = Console.ReadLine().Split(' ');
            a[i].ime = r[0];
            a[i].brojPoena = int.Parse(r[1]);
        }
        // 
        for (int i = 0; i < n - 1; i++)
        {
            int iMax = i;
            for (int j = i + 1; j < n; j++)
                if (uporedi(a[j], a[iMax]))
                    iMax = j;
            razmeni(ref a[iMax], ref a[i]);
        }
        Console.WriteLine("----------------------")
        for (int i = 0; i < n; i++)
            Console.WriteLine(a[i].ime + " " + a[i].brojPoena);
    }
}
/*
Input: 
5
Maja 56
Marko 78
Krsto 23
Jovan 78
Milica 89

Output:
Milica 89
Jovan 78
Marko 78
Maja 56
Krsto 23
*/
