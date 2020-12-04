using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int karta, zbroj = 0;

         while (zbroj < 31)
            {
                Console.WriteLine("Upišite broj karata: ");

                karta = Convert.ToInt32(Console.ReadLine());

                if (karta > 0 && karta <= 13)
                {
                    zbroj = karta + zbroj;
                }
            }
            if (zbroj == 31)
            {
                Console.WriteLine("Pobjeda");
            }
            if (zbroj != 31)
            {
                Console.WriteLine("Poraz");
            }
            Console.ReadKey();
        }
    }
}
