using System;

// packge trong c#
namespace BaitapAptech
{
    class Baitapcanban
    {
        static void Main(String[] args)
        {
            // khai bao bien
            int a, b, year;
            double hesoluong;

            Console.WriteLine("nhap vao so a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("yeu cau nhap so b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao nam sinh: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so luong: ");
            hesoluong = double.Parse(Console.ReadLine());

            int tong = a + b;
            int sotuoi = 2023 - year;
            int tuoihuu = 60 - sotuoi;
            double luong = hesoluong * 4500000.00;


            Console.WriteLine("tong {0} + {1} = {2}", a, b, tong);
            Console.WriteLine("tuoi cua ban la: " + sotuoi);
            Console.WriteLine("tuoi se ve huu cua ban: " + tuoihuu);
            Console.WriteLine("luong cua ban: " + luong);

            //dung man hinh tranh tat dot ngot
            Console.ReadKey();

        }
    }
}
