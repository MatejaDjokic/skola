using System;

public class KorektniTelefoni {
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] brojevi = new string[n];
        
        for (int i = 0; i < n; i++)
            brojevi[i] = Console.ReadLine();
        
        Array.Sort(brojevi);
        
        bool OK = true;
        
        for (int i = 1; i < n; i++)
            if (brojevi[i].StartsWith(brojevi[i-1]))
            {
                OK = false;
                break;
            }
        
        if (OK)
            Console.WriteLine("da");
        else
            Console.WriteLine("ne");
    }
}

/*
4
192
194
199342
192865
*/