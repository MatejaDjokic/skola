using System;

class Program
{
    public static bool Prost(long n)
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
        long n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Prost(n) ? "DA" : "NE");
    }
}

// svi negativni brojevi kao i broj 1 nisu prosti
// tjst. ne moze izracunati da li jesu zboj koriscenja korena
// u func za odredjivanje prostosti broja
// algoritam za izracunavanje prostosti broja
// i = 2 dok je i manje od n ponavljamo i proveravamo
// da li je rez od n / i ceo broj ako jeste
// onda broj n nije prost broj
// u svakom drugom slucaju vracamo true

