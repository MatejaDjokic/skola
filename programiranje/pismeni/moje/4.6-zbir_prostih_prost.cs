using System;

class Program {
    
    public static bool prost(int n) {
        if(n == 1)
            return false;
        
        for(int i = 2; i < n; i++)
            if(n % i == 0)
                return false;

        return true;
    }

    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int brojParova = 0;

        for(int p = 2; p <= n; p++)
            if(prost(p))
                for(int q = p + 1; p + q <= n; q++)
                    if(prost(q) && prost(p + q))
                        brojParova++;

        Console.WriteLine(brojParova);
    }
}