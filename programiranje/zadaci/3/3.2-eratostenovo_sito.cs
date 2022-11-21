using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
    public static bool Prost(int n)
    {
        if (n == 1) 
            return false;

        for (int i = 2; i < n; i++)
            if (n % i == 0)
                return false;

        return true;
    }

    public static void Sito(int a, int b)
    {
        int brojProstih = 0;
        List<int> prosti = new List<int>();
        for(int i = a; i < b; i++)
            if(Prost(i))
            {
                brojProstih++;
                prosti.Add(i);
            }
        Console.Write(brojProstih + " " + prosti.Sum() + " ");
    }

    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Sito(a,b);
    }
}

// func Sito() uzima a i b da kreira interval od a do b - [a,b]
// kreira listu u koju ce mo pomocu func Prost() da unesemo sve
// proste brojeve iz intervala [a,b]
// takodje brojeimo koliko imamo prostih brojeva u toj listi
// na kraju ispisujemo broj prostih brojeva u toj list i njihov zbir

