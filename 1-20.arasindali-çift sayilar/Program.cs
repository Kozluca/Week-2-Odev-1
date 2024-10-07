using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_20.arasindali_çift_sayilar
{
    internal class Program
    {
        static void Main(string[] args) // for döngüsü ile 1-20 arasındaki çift sayıları ekrana yazdırıyoruz
        {
            for (int i = 1; i<21; i++)
            {
                if (i%2==0) // for dögüsü içinde mod alma işlemi ile çift sayıları belirliyoruz
                {
                    Console.WriteLine(+i);
                }
            }
            Console.ReadKey();
        }
    }
}
