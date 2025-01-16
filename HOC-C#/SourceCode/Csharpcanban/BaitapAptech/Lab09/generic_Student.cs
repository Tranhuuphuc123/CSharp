using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    // tạo class Generic Student với type T
    class Student<T>
    {
        public T rollNo;
        public T fullname;


        // get and set
        public T RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                rollNo = value;
            }
        }

        public T FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }

        // contructor
        public Student(T rollNo, T fullName){
           this.RollNo = rollNo;
            this.FullName = fullname;
        }

        /* method nhập chung: hàm chuyển định dạng chung nhằm mục đích kh thực thi ở hàm main thì dù kiểu dữ liệu nào nó 
         cũng sẽ chuyển theo ý đồ của người lập trình
        */

        public void InputInfo()
        {
            Console.WriteLine("Nhap RollNo: ");
            // cách thứ chuyển đổi kiểu dl.. khi nhập ở hàm main ta định kiểu nào cũng đc nó sẽ tự chuyển đổi cho hợp lý
            RollNo = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Nhap ho ten: ");
            FullName = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
   
        // method checkJoinYear
        public bool CheckJoinYear(int year)
        {
            int year_start;
            year_start = int.Parse(RollNo.ToString().Substring(0, 4));
            return year == year_start;
        }


        // method Display
        public void Display()
        {
            int year;
            year = int.Parse(RollNo.ToString().Substring(0, 4));
            Console.WriteLine("ma sinh vien: " + RollNo);
            Console.WriteLine("ten sih vien: " + FullName);
            Console.WriteLine("nam nhap hoc cua sinh vien: " + year);
            
        }


        // method toString
        public override string ToString()
        {
            return RollNo + " " + FullName;
        }
    }



    class IntStudent : Student<int>
    {
        public int Year;

        public void InputInfo(int year)
        {
            base.InputInfo();
            Year = year;
        }

        public bool CheckJoinYear()
        {
            return base.CheckJoinYear(Year);
        }
    }

    class StringStudent : Student<string>
    {
        public string Year;

        public  void InputInfo(String year)
        {
            base.InputInfo();
            Year = year;
        }

        public bool CheckJoinYear()
        {
            return base.CheckJoinYear(int.Parse(Year));
        }
    }






    class Demo
    {
        static void Main(String[] args)
        {
            // đa di năng ở điểm vơi generic thì  khi gọi xuống hàm main thực thi ta mún gáng kiểu dữ liệu bào cho T cũng đc
           
        
            IntStudent intStudent = new IntStudent();
            intStudent.InputInfo();
            Console.WriteLine("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());

            intStudent.Display();

            if (intStudent.CheckJoinYear())
            {
                Console.WriteLine("Sinh vien da nhap hoc vao nam " + year);
            }
            else
            {
                Console.WriteLine("Sinh vien khong nhap hoc vao nam " + year);
            }

            Console.ReadKey();
        
        }
    }
}
