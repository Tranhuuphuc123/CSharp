using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Bài toán đặt ra là nhập vào một mảng ký tự sao đó in ra mảng ký tự đó và in ngược mảng ký tự đó
dùng Reverse hàm chuyển đổi trong String
 */
namespace CSharp_Core
{
    class Reverse_ingnguoc
    {
        static void Main(String[] args)
        {
            int n;
            Console.WriteLine("nhap gioi han mang ky tu can nhap: ");
            n=int.Parse(Console.ReadLine());
            
            char[] mangkytu = new char[n];

            Console.WriteLine("Nhap vao cac ky tu");
            Console.WriteLine("===============================");

            // nhap tung ky tu theo mang nha
            for(int i = 0; i < n; i++)
            {
                Console.Write("ky tu {0}: ", i);
                mangkytu[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            Console.WriteLine("xuat mang binh thuong");
            Console.WriteLine("=======================");
            // xuat mang binh thuong
            foreach(char c in mangkytu)
            {
                Console.Write(c + " ");
            }


            Console.WriteLine("xuat mang dao nguoc");
            Console.WriteLine("=======================");
            // xuat mang the chieu dao nguoc voi Reverse trong String
            foreach (char c in mangkytu.Reverse())
            {
                Console.Write(c + " ");
            }

        }
    }
}
