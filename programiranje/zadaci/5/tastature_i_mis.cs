using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
   public static void Main()
    {
        int broj_tastatura = int.Parse(Console.ReadLine());
int[] tastature = new int[broj_tastatura];
string[] str = Console.ReadLine().Split();
for (int i = 0; i < broj_tastatura; i++)
tastature[i] = int.Parse(str[i]);

int broj_miseva = int.Parse(Console.ReadLine());
int[] misevi = new int[broj_miseva];
str = Console.ReadLine().Split();
for (int i = 0; i < broj_miseva; i++)
misevi[i] = int.Parse(str[i]);

int budzet = int.Parse(Console.ReadLine());
int maks_cena = -1;
foreach (int t in tastature)
foreach (int m in misevi)
if (t + m <= budzet)
maks_cena = Math.Max(maks_cena, t + m);
Console.WriteLine(maks_cena);
    }
}