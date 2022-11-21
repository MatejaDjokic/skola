using System;

public class PravednaPodelaCokoladica {
    public static void Main(string[] args) {

        // ucitavamo brojeve cokoladica u paketima
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        
        string[] str = Console.ReadLine().Split();
        
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(str[i]);
        
        // ucitavamo broj dece
        int k = int.Parse(Console.ReadLine());;

        // sortiramo pakete po broju cokoladica
        Array.Sort(a);

        // odredjujemo i ispisujemo najmanju mogucu razliku za nekih k odabranih paketa
        int min = int.MaxValue;
        for (int i = 0; i + k - 1 < n; i++)
        {
            int razlika = a[i + k - 1] - a[i];
            if (razlika < min)
                min = razlika;
        }
        Console.WriteLine(min);
    }
}

/*
8
3 8 1 17 4 7 12 9
4
*/