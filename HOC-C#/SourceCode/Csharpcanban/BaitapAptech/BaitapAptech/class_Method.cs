using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapAptech
{
     /*xay dung class rieng*/
        class Rectangle{
            public float chieudai;
            public float chieurong;

            //contructor
            public Rectangle(){
                this.chieudai = 1;
                this.chieurong = 1;
            }

            //contructor co doi so
            public Rectangle(float x, float y){
                this.chieudai = x;
                this.chieurong = y;
            }

            //xay dung method
            public float getArea(){
                return (this.chieudai * this.chieurong);
            }


            //method isSquare
            public bool isSQuare(){
                if (this.chieudai == this.chieurong){
                    return true;
                }
                else{
                    return false;
                }

            }

            //kiem tra methof isRectangle
            public bool isRectangle(){
                if (this.chieudai > this.chieurong){
                    return true;
                }
                else{
                    return false;
                }
            }

            //ham huy contructor
            /*    ~Rectangle()
                {
                    Console.WriteLine("day la ham huy contructor");
                }*/

            //method toString
            public override String ToString(){
                return ("dien tich Area: " + this.chieudai + " * " + this.chieurong + " = " + (this.chieurong * this.chieurong));
            }

        }


        class Demo
        {
            /*ham main*/
            static void Main(String[] args)
            {
                float a, b;
                Console.WriteLine("nhap so a: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("nhap so b: ");
                b = float.Parse(Console.ReadLine());

                Rectangle rec = new Rectangle(a, b);
                Console.WriteLine("dien tich Area: " + rec.ToString());

                //kiem tra co phai hinh vuong
                if (rec.isSQuare())
                {
                    Console.WriteLine("ket qua cac canh ban nhap la hinh vuong");
                }
                else
                {
                    Console.WriteLine("ket qua cac canh ban nhap khong phai la hinh vuong");
                }

                // kiem tra cos phai hinh chu nhat
                if (rec.isRectangle())
                {
                    Console.WriteLine("day la hinh chu nhat");
                }
                else
                {
                    Console.WriteLine("day khog phai la hinh chu nhat");
                }

            }
        }
 
   
}
