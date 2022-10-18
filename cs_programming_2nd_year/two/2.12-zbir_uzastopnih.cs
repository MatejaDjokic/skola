using System;

public class Program
{
    public static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int brojNacina = 0;

        for(int a0 = 1; a0 + (a0 + 1) <= n; a0++)
        {
            int zbir = 0;
            for(int ai = a0; zbir < n; ai++)
                zbir += ai;
            if(zbir == n)
                brojNacina++;
        }
        Console.WriteLine(brojNacina);
    }
}

// unosimo n - broj koji treba da dobijemo
// inicijalizujemo brojNacina - promenljivu
// sabiramo brojeve jedan po jedan 
// proveravamo da li je zbir jednak zeljenom broju {n}
// ako jeste dodajemo 1 na brojNacina
// i na kraju ispisujemo