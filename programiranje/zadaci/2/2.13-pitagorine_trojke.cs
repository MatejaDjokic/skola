using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int a = 1; 2*a*a <= n*n; a++)
            for (int b = a; a*a + b*b <= n*n; b++) 
                for (int c = b+1; c <= n; c++)
                    if (a*a + b*b == c*c)
                        Console.WriteLine("{0} {1} {2}", a, b, c);
    }
}

// a = 1 2a^2 <= n^2
    // b = a a^2 + b^2 <= n^2
        // c = b + 1 c <= n 
            // if (a*a + b*b == c*c)

// a = 1, 2a^2 <= n^2
// b = a, a^2 + b^2 <= n^2
// c = b + 1, c <= n
// a^2 + b^2 = c^2
 
