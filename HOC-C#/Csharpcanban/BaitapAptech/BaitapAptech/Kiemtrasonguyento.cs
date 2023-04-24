using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapAptech
{
    class Kiemtrasonguyento
    {
        static bool songuyento(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= (n - 1); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("nhap vao so n: ");
            n = int.Parse(Console.ReadLine());

            if (songuyento(n))
            {
                Console.WriteLine("day la so nguyen to");
            }
            else
            {
                Console.WriteLine("day khong phai la so nguyen to");
            }

            Console.ReadKey();

        }
    }
}
