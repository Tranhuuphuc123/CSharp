using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapAptech
{
    internal class Timthangnam
    {
        static void Main(String[] args)
        {
            int year, month;

            Console.WriteLine("nhap vao thang: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao so nam: ");
            year = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine(" thang co 31 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("thang co 30 ngay");
                    break;

                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine("thang 02 co 29 ngay nam nhuan");
                    }
                    else
                    {
                        Console.WriteLine("thang 02 co 28 ngay nam thuong");
                    }
                    break;

                default:
                    Console.WriteLine("nhung th nay ngoai le");
                    break;

            }
            Console.ReadKey();
        }
    }
}
