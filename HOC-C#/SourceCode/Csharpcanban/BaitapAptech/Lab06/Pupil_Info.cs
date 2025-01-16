using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// bài tạp số 04  trong L6.pdf
//nôi dung yêu cầu: Writing a program to store information of a pupil and display the details of this pupil. 

namespace Lab06
{
    class Pupil
    {
        //make fields(data member)
        private String _PupilCode;
        private String _FullName;
        private double _Math;
        private double _Literature;
        private String _Rate;

        //properties (get and set)
        public String PupilCode
        {
            get { return _PupilCode; }

            set
            {
                _PupilCode = value;
            }
        }

       public String FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
            }
        }

        public double Math
        {
            get { return _Math; }
            set
            {
                if(value < 0 || value > 10)
                {
                    Console.WriteLine("nhap diem lai: ");
                    _Math = double.Parse(Console.ReadLine());                 
                }
                    _Math = value;
                    UpdateRate();
            }
        }

        public double Literature
        {
            get { return _Literature; }
            set
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("nhap diem lai: ");
                    _Literature = double.Parse(Console.ReadLine());
                }
                    _Literature = value;
                    UpdateRate();
            }
        }


        // tinh diem tb
        public String Rate
        {
            get;private set;//  dây là cách viết read only--> đây là cách viết mới.
        }
        
        public void UpdateRate(){
            double dtb = (_Math + _Literature) / 2;
            if (dtb > 9)
            {
                Rate = "Outstanding";
            }else if(dtb > 8)
            {
                Rate = "Excellent";
            }else if (dtb > 6)
            {
                Rate = "Distinction";
            }else if (dtb > 4)
            {
                Rate = "Pass";
            }
            else
            {
                Rate = "Fail";
            }
        }

        //contructor

        public Pupil() { }
        public Pupil(String pupilcode, String fullname)
        {
            this.PupilCode = pupilcode;
            this.FullName = fullname;
            this.Math = 0;
            this.Literature = 0;
        }

        public Pupil(String pupilcode, String fulname,double math, double literature)
        {
            this.PupilCode = pupilcode;
            this.FullName = fulname;
            this.Math = math;
            this.Literature = literature;
        }

        // method toString
        public override string ToString()
        {
            return "PupilCode of Pupil: " + this.PupilCode + "\n Fullname: " + this.FullName + "\n Math: " + this.Math + "\n Lit: " + this.Literature
              + "\n diem tb = " + ((this.Math + this.Literature) / 2) + "\n xep loai: " + this.Rate;
        }
    }


    // class demo
    class Demo
    {
        public static void Main(String[] args)
        {
            Pupil pupil = new Pupil();
            pupil.PupilCode = "M001";
            pupil.FullName = "tran huu phuc";
            pupil.Math = 7.8;
            pupil.Literature = 6.7;
            Console.WriteLine(pupil.ToString());

            Console.ReadKey();
        }
    }   
}
