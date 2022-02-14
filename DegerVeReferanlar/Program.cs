using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 45;



            int[] sayi3 = { 10, 20, 30 };
            int[] sayi4 = { 100, 200, 300 };



            Console.WriteLine(sayi1);

            Console.ReadKey();
        }
    }
}
