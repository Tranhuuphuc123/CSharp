using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// bài tập nền tảng về toán học cơ bản
namespace CSharp_Core
{
    class calculator
    {
        private String _Name;
        private double _Math;
        private double _Literature;

        // get and set
        public String Name
        {
            get { return _Name; }
            set
            {
                Regex regex = new Regex("^[A-Za-z ]+$");
                if (regex.IsMatch(value))
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("yeu cau nhap lai ten");
                    _Name = Console.ReadLine();
                }
            }
        }

        public double Math
        {
            get { return _Math; }
            set
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("diem vuot qua quy dinh- nhap lai");
                    _Math = int.Parse(Console.ReadLine());
                }
                _Math = value;
            }
        }

        public double Literature
        {
            get { return _Literature; }
            set
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("diem vuot qua quy dinh- nhap lai");
                    _Literature = int.Parse(Console.ReadLine());
                }
                _Literature = value;
            }
        }


        // xep loai
        public void Xeploai()
        {
            double diemtrungbinh = ((Math + _Literature) / 2);
            if (diemtrungbinh > 9 )
            {
                Console.WriteLine("xuat sac");
            }
            else if(diemtrungbinh > 8)
            {
                Console.WriteLine("Gioi");
            }else if (diemtrungbinh>6)
            {
                Console.WriteLine("Kha");
            }else if(diemtrungbinh > 4)
            {
                Console.WriteLine("trung binh");
            }
            else
            {
                Console.WriteLine("yeu");
            }
           
        }

    }           


     class Demo
    {
       static void Main(String[] args)
        {
            calculator cal = new calculator();
            Console.WriteLine("nhap ten: ");
            cal.Name = Console.ReadLine();
            Console.WriteLine("nhap diem toan: ");
            cal.Math=double.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem van: ");
            cal.Literature=double.Parse(Console.ReadLine());

            //inr ra diem tb;
            double diemtrungbinh = ((cal.Math + cal.Literature) / 2.0);
            Console.WriteLine("diem tb: " + diemtrungbinh);


            Console.Write("xep loai: "); cal.Xeploai();

        }
    }
}
