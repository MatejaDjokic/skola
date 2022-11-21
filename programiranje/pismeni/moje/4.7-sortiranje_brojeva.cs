using System; 

class SortiranjeBrojeva {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++) {
            a[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(a);
        foreach (var item in a){
            Console.WriteLine(item);
        }
    }
}