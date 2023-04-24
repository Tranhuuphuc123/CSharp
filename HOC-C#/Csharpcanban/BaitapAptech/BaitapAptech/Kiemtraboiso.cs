using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapAptech
{
     class Kiemtraboiso
    {
        static void Main(String[] args)
        {
            int n;
            int count = 0;
            Console.WriteLine("nhap vao so n");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                    count += i;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("tong cac boi so cua 7 la: " + count);
            Console.ReadKey();
        }
    }
}
