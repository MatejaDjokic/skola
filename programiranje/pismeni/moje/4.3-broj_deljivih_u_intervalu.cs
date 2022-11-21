using Internal;
using System;

public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int brojac = 0;
        for (int i = a; i <= b; i++) {
            if(i % k == 0) {
                brojac++;
            }
        }
        Console.WriteLine(brojac);
        
    }
}

/*

a - pocetak intervala
b - kraj intervala 
k - broj kojim delimo

iteriramo od a do b [a,b] <= nas interval od a do b
proveravamo da li je i deljivo sa k ako jeste 
povecavamo broj deljivih iz intervala 
ako ne nastavljamo dalje
na kraju ispisujemo broj deljivih u intervalu{brojac}

*/