using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// tuyển tập các bài tập vẽ hình luyện tư duy về vòng lặp và tư duy phân tích
namespace CSharp_Core
{
    // class vẽ tam giác với các dộ dài cạnh bằng nhau tức tam giác đều
    class tamgiacdeu
    {
        public void vehinh()
        {
            int lenght;
            Console.WriteLine("nhap vao chieu dai canh: ");
            // text dieu kien neu nhap so am se nhap lai
            while (!int.TryParse(Console.ReadLine(), out lenght)){
                Console.WriteLine("Vui long nhap lai so nguyen duong");
            }


            // xuat gia tri theo cau truc nested for for
            // dau tien se in ra so row, moi row xuong dog cai dua tren so chieu dai minh nhap vao
            for (int i = 1; i <= lenght; i++)
            {
                //vong lap nay nham in ra khoang trang dung trc moi ky tu ve tam giac
                for (int j = 1; j <= lenght - i; j++)
                {
                    Console.Write(" ");
                }


                // vong lap ke tiep in ra hinh dang ky tu tam gia(vd: dau ky tu *)
                /*
                 in ra tam gia deu cong thuc: i*2-1:
                  - nghia la vd chieu dai hinh tam gia la 5, thi no se in ra
                   + dong 1:     _ * _      co 1 khoang trang trc dau * va 1 ky tu *
                   + dong 2:  _ *  *  * _   co 1 khoang trang trc dau *, * se dc tinh nhu sau: o vl2: i=2*2-1=>i=3, vay co 3 dau *
                   + dong 3:_ *  *  *  * _   co 1 khoang trang trc dau *, * se dc tinh tg tu tren vl3: i=3*2-1=>i=4, vay cos 4 dau * 
                    ..........tg tuwj cho den het vong lap 5 row, va dau sao se bang 9* neu lenght bang 5.
                 */
                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }



    // class texter Demo
    class Demo
    {
        static void Main(String[] args)
        {
            // goi thuc thi class tam giac deu
            tamgiacdeu tgd = new tamgiacdeu();
            tgd.vehinh();
        }
    }
}
