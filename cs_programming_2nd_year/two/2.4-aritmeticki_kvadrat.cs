using Microsoft.Win32;
using System;

    class Program
    {
        public static     void ZbirReda(int n, int i)
        {
            //i++;

            int zbirReda1 = 0, zbirReda2 = 0;
            int brojMesta1 = n * i;
            int brojMesta2 = n * (i - 1);

            for (int k = -1; k < brojMesta1; k++)
                zbirReda1 += k;

            for (int k = -1; k < brojMesta2; k++)
                zbirReda2 += k;

            int zbirReda = zbirReda1 - zbirReda2;
            Console.WriteLine(zbirReda);
        }

        public static    void ZbirKolone(int n, int i)
        {
            double zbirKolone = ((Math.Pow(n, 3) - Math.Pow(n, 2)) / 2) + (n * i);
            Console.WriteLine(zbirKolone);
        }

        public static    void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());

            ZbirReda(n, i);
            ZbirKolone(n, i);
    }
}
