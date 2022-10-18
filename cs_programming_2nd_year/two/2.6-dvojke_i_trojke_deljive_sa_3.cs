using System;

    public class Program
    {
        public static int Mogucnosti(int[] arr, int x)
        {
            int[] c = new int[]{0, 0, 0};
            int i;
            int rez = 0;
                
            for (i = 0; i < x; i++)
                c[arr[i] % 3]++;
                
            rez += ((c[0] * (c[0] - 1)) >> 1);
            rez += c[1] * c[2];
            rez += (c[0] * (c[0] - 1) * (c[0] - 2)) / 6;
            rez += (c[1] * (c[1] - 1) *(c[1] - 2)) / 6;
            rez += ((c[2] * (c[2] - 1) * (c[2] - 2)) / 6);
            rez += c[0] * c[1] * c[2];

            return rez;    
        }
        
        public static void Main()
        {
            Program program = new Program();
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int x = arr.Length;
            Console.Write(Mogucnosti(arr, x));
        }   
    }
