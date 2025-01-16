using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*tiềm hiểu về các bài tập mảng*/
namespace BaitapAptech
{
    //xây dựng class Đọc và in các phần tử mảng
    class read_print_Array
    {
        public void read_print()
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("doc dl mang va in ra dl mang");
            Console.WriteLine("=============================");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("mang[{0}]",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //xuat mang
            Console.WriteLine("================kw===============");

            for(i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
        
    }


    //class nhập xuất mảng 2 chiều
    class array_2c
    {
        public void read_print()
        {
            int i, j;
            int[,] arr = new int[3, 3];

            Console.WriteLine("Array 2c");
            Console.WriteLine("==============================");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("phantu[{0},{1}]", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());  
                }
            }

            //xuat mang 2 chieu
            Console.WriteLine("===========kw===============");

            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t",arr[i, j]);
                }
            }
            Console.Write("\n\n");


        }
    }




    //class texter- main chính
    public class Texter
    {
        static void Main(String[] args)
        {
            //goi class nhap va in dl mang
            /* read_print_Array r = new read_print_Array();
             r.read_print();*/

            array_2c a = new array_2c();
            a.read_print();


            Console.ReadKey();
        }
    }
}
