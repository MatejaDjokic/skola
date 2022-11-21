using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbir_prostih_prost
{
    internal class Program
    {
        //  provera prostosti broja
        static bool ProstBroj(int n)
        {
            // ako je n jedan onda nije prost
            if (n == 1)
                return false;
            // delimo n sa brojevima od 2 pa do n - 1
            // i proveravamo da li su celi brojevi ako jesu onda 
            // n nije prost broj 
            for(int i = 2; i < n; i++)
                if(n % i == 0)
                    return false;
            // u svakom drugom slucaju n je prost broj
            return true;
        }

        static void Main(string[] args)
        {
            // unos n
            int n = int.Parse(Console.ReadLine());

            // unos rezultata
            int res = 0;
            
            // iniciramo p sa vrednoscu 2 i proveravamo kroz for loop da li je manje ili jednako od n
            for (int p = 2; p <= n; p++)
                // ako jeste proveravamo da li je p prost broj
                if (ProstBroj(p))
                    // iniciramo q sa vrednoscu p + 1 i proveravamo da lije zbir p i q manji ili jednak od n
                    for (int q = p + 1; p + q <= n; q++)
                        // ako jeste proveravamo da lije q prost broj i da lije njihov zbir prost broj
                        if (ProstBroj(q) && ProstBroj(q + p))
                            // ako jeste povecavamo brojac rezultat
                            res++;

            // i spisujemo rezultat
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
