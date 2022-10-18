using System;

public class GFG
{
    static void decToBinary(int n)
    {
        int[] ostatak = new int[100];
        int i = 0;
        while (n > 0)
        {
            ostatak[i] = n % 2;
            n = n / 2;
            i++;
        }
        for (int j = i - 1; j >= 0; j--) Console.Write(ostatak[j]);
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decToBinary (n);
    }
}
