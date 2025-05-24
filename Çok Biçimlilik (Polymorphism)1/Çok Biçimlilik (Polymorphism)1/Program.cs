using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çok_Biçimlilik__Polymorphism_1
{
    internal class Program
    {
        class HesapMakinesi
        {
            // Topla(int, int)
            public int Topla(int a, int b)
            {
                return a + b;
            }

            // Topla(double, double)
            public double Topla(double a, double b)
            {
                return a + b;
            }

            // Topla(int, int, int)
            public int Topla(int a, int b, int c)
            {
                return a + b + c;
            }
        }
        static void Main(string[] args)
        {
            HesapMakinesi hm = new HesapMakinesi();

            Console.WriteLine(hm.Topla(3, 5));           // int + int
            Console.WriteLine(hm.Topla(2.5, 4.7));       // double + double
            Console.WriteLine(hm.Topla(1, 2, 3));        // int + int + int
        }
    }
}
