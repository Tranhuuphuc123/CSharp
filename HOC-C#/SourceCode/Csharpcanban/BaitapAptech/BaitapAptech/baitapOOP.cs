using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// bài tập về nhà thầy giao class and Method OOP 

namespace BaitapAptech
{
    public class baitapOOP
    {
        //ham Main
        static void Main(String[] args)
        {
            String ten;
            DateTime namsinh;
            DateTime ngaylamviec;

            Console.WriteLine("nhap ten: ");
            ten= Console.ReadLine();

            Console.WriteLine("nhap namsinh: ");
            String input = Console.ReadLine();
            namsinh = DateTime.ParseExact(input,"dd/MM/yyyy",null);

            Console.WriteLine("nhap ngaylamviec: ");
            String input2 = Console.ReadLine();
            ngaylamviec = DateTime.ParseExact(input2, "dd/MM/yyyy", null);

            Employee emp = new Employee(ten, namsinh, ngaylamviec);

            emp.Display();

            Console.ReadKey();
        }


        //class Person
        public class Person{
            private String FullName;
            private DateTime Birthday;

            //contructor
            public Person(string fullName, DateTime birthday)
            {
                this.FullName = fullName;
                this.Birthday = birthday;
            }

            //method getAge
            public int getAge()
            {
                //lấy năm hiện tại
                DateTime namhientai = DateTime.Now;
                int age = namhientai.Year - this.Birthday.Year;
                if (namhientai < this.Birthday.AddYears(age))
                {
                    age--;
                }
                return age;
            }

            //method Display
            public virtual void Display()
            {
            /*trong C# Viturtal khai báo nhằm mục đích cho lớp con có thể ghi đè, nếu không có nó sẽ không ghi đè đc
             virtual trong lớp cha, lớp con có thể ghi đè nó bằng cách sử dụng từ khóa override.
             */
                Console.WriteLine("ten cua ban la: " + FullName);
                Console.WriteLine("tuoi cua ban la: " + getAge());
            }

        }



        //class Employee
        public class Employee : Person
        {
            private DateTime JoinDate;

            //contructor
            public Employee(String FullName, DateTime Birthday, DateTime joinDate) : base(FullName, Birthday)
            {
                //base tg tu super() khi ke thua tu lop cha   
                this.JoinDate = joinDate;
            }

            //method WorkingYear()
            public int WorkingYear()
            {
                DateTime namhientai = DateTime.Now;
                int sonamlamviec = namhientai.Year - this.JoinDate.Year;
                return sonamlamviec;
            }

            //method DisPlay
            private float mucluongcoban = 1500.0F;
            public override void Display()
            {
                base.Display();
                Console.WriteLine("ngay vao lam viec: " + JoinDate);
                Console.WriteLine("ban da lam viec duoc: " + WorkingYear());

                if (WorkingYear() > 3)
                {
                    mucluongcoban += 500;
                    Console.WriteLine("ban da lam viec tren 3 nam so luong cua ban la: " +mucluongcoban );
                }
                else
                {
                    Console.WriteLine("muc luong cua ban la: " + mucluongcoban);
                }
            }
       
                
        }


        //end program
    }
}
