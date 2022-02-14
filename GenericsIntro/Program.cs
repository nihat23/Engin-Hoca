using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            // isimler.Add("engin");



            List<string> isimler2 = new List<string>();
            Console.WriteLine(isimler2.Count);

           // Console.WriteLine(isimler);




            Console.ReadKey();

        }
    }
}
