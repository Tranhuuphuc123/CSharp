using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapAptech
{
    internal class Menu
    {
        static void Main(String[] args)
        {
            int n;
            do
            {
                Console.WriteLine("=======Menu=================");
                Console.WriteLine("ban hay lua chon cac ba tap duoi day: ");
                Console.WriteLine("1. bai tap can ban ");
                Console.WriteLine("2.Bai tap kiem tra boi so");
                Console.WriteLine("3. Bai tap kiem tra so nguyen to");
                Console.WriteLine("0.exit");

                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        baitapcanban btcb = new baitapcanban();
                        break;
                    case 2:
                        Kiemtraboiso ktbs = new Kiemtraboiso();
                        break;
                    case 3:
                        Kiemtrasonguyento snt = new Kiemtrasonguyento();
                        break;

                    default:
                        Console.WriteLine("vui long chon theo menu lenh");
                        break;

                }

            } while (n != 0);

            Console.ReadKey();
        }
    }
}
