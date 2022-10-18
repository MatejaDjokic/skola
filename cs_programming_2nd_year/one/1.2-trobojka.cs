using System;

class Program
{
    // funkcija ucitava elemente niza sa standadnog ulaza
    public static int[] unosNiza()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        string[] str = Console.ReadLine().Split();
        for(int i = 0; i < n; i++)
            a[i] = int.Parse(str[i]);
        return a;
    }

    // razmena elemenata a[i] i a[j]
    public static void zameni(int[] a, int i, int j)
    {
        int pom = a[i];
        a[i] = a[j];
        a[j] = pom;
    }

    // funkcija organizuje elemente vektora tako da se prvo nalaze
    // elementi za koje vazi da su iz intervala (-Inf, A), nakon
    // toga dolaze elementi iz intervala [A, B], i nakon toga
    // elementi iz intervala (B, Inf)
    public static void podelaNiza(int[] niz, int A, int B)
    {
        // - u intervalu pozicija [0, l) su elementi iz intervala (-Inf, A)
        // - u intervalu pozicija [l, i) su elementi iz intervala [A, B]
        // - u intervalu pozicija [i, d) su jos neispitani elementi
        // - u intervalu pozicija [d, n) su elementi iz intervala (B, Inf)
        int l = 0, i = 0, d = niz.Length;
        // dok god postoje neispitani elementi
        while (i < d)
        {
            if (niz[i] < A)
                // menjamo tekuci element sa prvim elementom iz
                // intervala [A, B]
                zameni(niz, i++, l++);
            else if (niz[i] <= B)
                // tekuci element ostaje na svom mestu
                i++;
            else
                // menjamo tekuci element sa poslednjim neispitanim
                zameni(niz, i, --d);
        }
    }

    // funkcija ispisuje elemente niza na standardni izlaz
    public static void ispisNiza(int[] a, int A, int B)
    {
        int i = 0;
        // ispisujemo elemente iz intervala (-Inf, A)
        while (i < a.Length && a[i] < A)
            Console.Write(a[i++] + " ");
        Console.WriteLine();
        // ispisujemo elemente iz intervala [A, B]
        while (i < a.Length && a[i] <= B)
            Console.Write(a[i++] + " ");
        Console.WriteLine();
        // ispisujemo elemente iz intervala (B, +Inf)
        while (i < a.Length)
            Console.Write(a[i++] + " ");
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        // ucitavamo elemente niza
        int[] a = unosNiza();
        // ucitavamo interval [A, B]
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
            
        // reorganizujemo elemente po intervalima (-inf, A),
        // [A, B] i [B, inf)
        podelaNiza(a, A, B);

        // ispisujemo rezultat
        ispisNiza(a, A, B);

		Console.Write("COMPLETED");
		Console.Write("\n");
    }
}