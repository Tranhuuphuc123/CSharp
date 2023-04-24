using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace
namespace BaitapAptech
{
    //khái báo tên class
    class Chuongtrinhdautien
    {
        static void Main(String[] args)
        {
            Console.WriteLine("hello C#!");

            //khai báo biến
            int a, b;
            //input
            Console.WriteLine("nhap so a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap so b");
            b = int.Parse(Console.ReadLine());

            int tong = a + b;
            //output
            Console.WriteLine("tong " + a + "+" + b + "=" + tong);

            //lệnh dừng màn hình chánh bị tắt đột ngột
            Console.ReadKey();

        }
    }

}
