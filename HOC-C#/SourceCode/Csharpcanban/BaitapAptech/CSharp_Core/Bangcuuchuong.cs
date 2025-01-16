using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* bai tap in bang cuu chuong: vd nhap 4-> in ra bang cuu chuong 4*/
namespace CSharp_Core
{
    // class in ra tat ca bang cuu chuong
    class Allbangnhan{
        public void Bangnhantongthe()
        {
            int i, j;
            Console.WriteLine("bang cuu chuong");
            Console.WriteLine("=====================");

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + j + " = " + i * j);
                }
                Console.WriteLine("\n\n");
            }
        }  
    }


    //class tim bang cuu chuong mun tim
    class Bangcuuchuong
    {
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("nhap vao bang cuu chuong can tim: ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("=======================");
            Console.WriteLine("bang cuu chuong {0}", n);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + n * i);
            }

            Console.ReadKey();

        }
    }
}
