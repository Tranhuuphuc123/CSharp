using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*trong bài tập này sẽ làm đc 2 vai tro:
  + 1/ là nhập vào ký tự bất kỳ và mún in ký tự đó ra hình dạng là tam giác
  + 2/ dùng vòng lặp để in ra tam giác vuông..
  + 3/ in ngược lai
 */
namespace CSharp_Core
{
     class Vetamgiac
    {
        static void Main(String[] args)
        {
            char kytu;
            int height, width;

            Console.WriteLine("nhap ky tu muon in ra hinh tam giac: ");
            kytu = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("nhap chieu rong width: ");
            width = int.Parse(Console.ReadLine());

            height = width;

            // xuat thong tin
            for(int row =0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(kytu);
                }
                //luc nay quyet dinh xem chieu rong se tang giam
                // nghia la row tg ungw chieu cao no phai tang
                //chieu rong tg ung column no tang hay giam se ra hinh dang tam giac: ys laf nos giam  thi ra hinh tam giac co dinh o duoi con tang thi ngc lai
                Console.WriteLine();
                width--;
            }
            Console.WriteLine("\n");
            Console.WriteLine("============in nguoc lai=================");
            for (int row = 0; row < height; row++)
            {
                for (int column = width-1; column >= 0; column--)
                {
                    Console.Write(kytu);
                }
                //luc nay quyet dinh xem chieu rong se tang giam
                // nghia laf row tg ungw chieu cao no phai tang
                //chieu rong tg ung column no tang hay giam se ra hinh dang tam giac: ys laf nos giam  thi ra hinh tam giac co dinh o duoi con tang thi ngc lai
                Console.WriteLine();
                width++;
            }
            Console.ReadKey();
        }
        
    }
}
