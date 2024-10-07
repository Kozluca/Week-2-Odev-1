using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2.Odev_1_5.uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        { // for dögüsü ile 1-120 arasındaki tek ve çift sayıların toplamnını ayrı ayrı ekrana yazdırıyoruz
            int result1 = 0;
            int result2 = 0;
            for (int i = 0; i < 121; i++)
            {
                if (i % 2 == 0)   // mod alma işlemi ile sayıların tek mi çift mi olduğunu tanımlıyoruz.
                {
                    result1 = i + result1; // for döngüsü içinde toplama işlemi
                }

                else if (i % 2 == 1)
                {
                    result2 = i + result2; // for döngüsü içinde toplama işlemi
                }
            } // sonucu ekrana yazdırıyoruz
            Console.WriteLine("Çift sayıların toplam: " + result1);
            Console.WriteLine("tek sayıların toplam: " + result2);
            Console.ReadKey();
        }
    }
}
