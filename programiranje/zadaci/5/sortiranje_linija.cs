using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ucitavamo liniju po liniju dok ne dodjemo do kraja ulaza
        // linije smestamo u listu, jer ne znamo unapred koliko ce ih biti
        List<string> linije = new List<string>();

        string linija;
        while ((linija = Console.ReadLine()) != null)
            // dodajemo liniju u listu
            linije.Add(linija);
        // soritramo linije
        linije.Sort(StringComparer.CurrentCultureIgnoreCase);
        // ispisujemo sortirane linije
        foreach (string l in linije)
            Console.WriteLine(l);
    }
}