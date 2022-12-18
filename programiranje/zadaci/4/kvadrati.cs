using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
            List<int> vec = new List<int>(100);

            vec[0] = 1;
            vec[1] = 5;
            
            Console.WriteLine(vec[0] + vec[1]);
            Console.WriteLine("Done");
        }
    }
}