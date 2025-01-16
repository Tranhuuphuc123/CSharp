using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Sử dụng câu điều kiện ?  true : false
 ===> Để tiến hành kiểm tra chăn lẻ
 */
namespace CSharp_Core
{
     class Kiemchanle
    {
        static void Main(String[] args)
        {
            int n1, n2;
            Console.WriteLine("nhap so n1: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so n2: ");
            n2=int.Parse(Console.ReadLine());

            bool kiemchachanle = ((n1 % 2 == 0 && n2 % 2 == 0) ? true : false);

            Console.WriteLine(kiemchachanle ? "So vau nhap la so chan" : "So nhap la cac so le");

            Console.ReadKey();
        }
    }
}
