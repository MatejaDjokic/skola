using System;

class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();

        long a = long.Parse(str[0]);
        long b = long.Parse(str[1]);
        long c = long.Parse(str[2]);

        long maks = a * (b + c);

        for (long i = 1; i <= c; i++)
            maks = Math.Max(maks, (a+i)*(b+c-i));

        Console.WriteLine(maks);
    }
}
// unosimo a, b, c u jednom redu u niz
// u odnosu na indekse niza zadajemo promenljive
// izracunavanje pocetnog maksimuma 
// proveravanje Math.Max funkcijom koji maks je veci i krairanje novog maksa
// prebacivanjem vrednosti iz c jedan po jedan u a i gledanje 
// kako se dobija najveci maksimum