using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*kiem tra xem so ky tu xuat hien trong mot chuoi*/
namespace Baikiemtra01
{
     class bai03
    {
       static void Main(String[] args)
        {
            String str;
            Console.WriteLine("nhap vao chuoi: ");
            str = Console.ReadLine();

            //kiem tra
            int count = 0;
            foreach(char c in str)
            {
                count++;
            }
            Console.WriteLine("so tu xuat hien la: " + count);
        }
    }
}
