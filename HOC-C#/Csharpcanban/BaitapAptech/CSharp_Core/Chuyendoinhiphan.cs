using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* thuc hien chuyen doi so thap phan sang nhi phan, so nguyen sang nhi phan và so thap luc phan (dang 1,2...A, B, C)
 p^2: chia cho 2
  + chia %2 == 0
  + chia phan nguyen /2 = ..==> de lay phan nguyen tach phan thap phan
  + thuc hien tuan tu de tach ket qua => 
 */

namespace CSharp_Core
{
    //class chuyen songuyen sang nhi phan
    class So_nguyen
    {
        public void Chuyendoinhiphan(int n)
        {
            String chuyendoi = " ";
            while (n > 1)
            {
                // phai chia het cho 2 de ra gia tri true 1, va fasle 0-> cong don vao chuoi rong
                chuyendoi = n%2 + chuyendoi;
                // thuc chia phan nguyen 2 de nhuwng so !%2 thi no se tach bo phan thap phan de lay phan nguyen thui
                n /= 2;
            }
            Console.WriteLine("Ma nhi phan cua {0}: {1}", n, chuyendoi);
        }
    }


    //class thapphan 
    class So_thapphan
    {
        public void chuyendoinhiphan(double n)
        {
            String chuyendoi = " ";
            
        }
    }


    //class thap luc phan



    // class texter Demo
    public class Demo
    {
        static void Main(String[] args)
        {
            int n;
            double n1;
            String n2;

            Console.WriteLine("nhap so n: ");
            n =int.Parse(Console.ReadLine());

            So_nguyen sn = new So_nguyen();
            sn.Chuyendoinhiphan(n);

        }
    }
    
}
