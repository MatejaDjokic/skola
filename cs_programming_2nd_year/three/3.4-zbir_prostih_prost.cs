using System;

class Program
{
    public static bool prost(int n)
    {
        if (n == 1) 
            return false;

        for (int i = 2; i < n; i++)
            if (n % i == 0)
                return false;

        return true;
    }
   
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int brojParova = 0;

        for (int p = 2; p <= n; p++)
            if (prost(p))
                for (int q = p+1; p+q <= n; q++)
                    if (prost(q) && prost(p+q))
                        brojParova++;

        Console.WriteLine(brojParova);
    }
}

// inicijalizujemo broj koji koristimo i 
// brojParova koje na kraju ispisujemo
// inicijalizujemo p = 2 i iteriramo sve dok je p <= n
// onda proveravamo da li je p prost broj 
// kreiramo q koje je uvek vece za 1 od p => q = p + 1
// iteriramo sve dok je zbir p i q <= n 
// onda proveravamo da li je p prost broj i da li je zbir p i q prosto
// ako jeste inkrementujemo brojParova => imamo novi par 
// na kraju br parova ispisujemo
