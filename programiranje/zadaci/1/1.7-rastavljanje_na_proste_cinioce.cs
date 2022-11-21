using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = 2;

        while (n > 1)
        {
            while (n % f == 0)
            {
                Console.Write(f + " ");

                n /= f;
            }
            f = f + 1;
        } 
        Console.WriteLine();
    }
}

/*
unos n - broja koji rastavljamo 
unos f - prvog potencijalnog delioca - (2)

dok je n > 1 i dok je n / f => celo
    ispisi f + razmak
    podeli n sa f 
    i ponavlaj
ako n / f => nije celo
    na f dodaj njega + 1
*/