using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2._1_20_arasindaki_sayilar
{
    internal class Program
    {
        static void Main(string[] args)  // for döngüsü ile 1-20 arasındaki sayiları ekrana yazdırdıyoruz
        {
            
            for (int i = 1; i<21; i++) 
            {
                Console.WriteLine(i); 
            }
            Console.ReadKey();
        }
    }
}
