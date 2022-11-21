using System;

class Program
{
    static int NZD(int a, int b)
    {
        while(a != b)
        {
            if(a > b)
                a -= b;
            else 
                b -= a;
        }
        return a;
    }

    static void Main(string[] args)
    {
       int mravi = int.Parse(Console.ReadLine());
       int pcele = int.Parse(Console.ReadLine());
       int komarci = int.Parse(Console.ReadLine());

        int nzd = NZD(NZD(mravi, pcele), komarci);

        Console.WriteLine(nzd);

    }
}
 
// funkcija za izracunavanje najveceg zajednickog delioca
// po euklidovoj fomuli 
// a = b nzd(a) = nzd(b)
// a > b nzd(a,b) = nzd(a-b,a)
// a < b nzd(a,b) = nzd(a, b-a)
// u Main()-u unosimo broj mrava, pcela i komaraca
// onda pomocu NZD() func izracunavamo nzd za sva 
// tri elementa i ispisujemo ga
