using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2._50_ile_150.arasındaki.sayilar.toplami
{
    internal class Program
    {
        static void Main(string[] args) // for döngüsü ile 50-150 arasındaki sayiların toplamını yazdırıyoruz
        {
            int sonuc = 0;
            for (int i = 50; i < 151; i++)
            {
                sonuc = sonuc + i; // for döngüsü içinde toplama işlemi
            }
            Console.WriteLine(sonuc); // sonucu ekrana yazdırıyoruz
            Console.ReadKey();
        }
    }
}
