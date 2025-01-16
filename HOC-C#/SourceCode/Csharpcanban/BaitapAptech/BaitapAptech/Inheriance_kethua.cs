using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BaitapAptech
{
    //class Person
    class Person
    {
        private String _FullName;
        private DateTime _Birthday;



        //get and set
        public String FullName
        {
            get { return _FullName; }
            set
            {
                //$ la dai dien khoang trang
                //Regex ham kiem tra dau vao cua chuoi ky tu
                Regex re = new Regex("^[A-Za-z ]+$");
                if (re.IsMatch(value))
                {
                    _FullName = value;
                }
                else
                {
                    Console.WriteLine("vui long nhap lai ten: ");
                    _FullName = Console.ReadLine();
                }
            }
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                if (value.Year <= DateTime.Now.Year)
                {
                    _Birthday = value;
                }
                else
                {
                    Console.WriteLine("vui long nhap lai ngay sinh");
                    String mahoa = Console.ReadLine();
                    _Birthday = DateTime.ParseExact(mahoa, "dd/MM/yyyy", null);
                }
            }
        }

        //contructor
        public Person() { }
        public Person(String fullname, DateTime birthday)
        {
            this.FullName = fullname;
            this.Birthday = birthday;
        }

        //method getAge
        public int getAge()
        {
            int age = DateTime.Now.Year - this.Birthday.Year;
            if (age > 0)
            {
                return age;
            }
            else
            {
                return 1;
            }

        }

        //method Display
        public virtual void Display()
        {
            Console.WriteLine("ten cua ban la: " + this.FullName);
            Console.WriteLine("tuoi cua ban la: " + this.getAge());
        }

    }



    //class Employee
    class Employee : Person // class employee đang kế thừa class Person
    {
        DateTime _JoinDate;
        private int i;

        //get and set
        public DateTime JoinDate
        {
            get { return _JoinDate; }
            set
            {
                if (value.Year <= DateTime.Now.Year)
                {
                    _JoinDate = value;
                }
                else
                {
                    Console.WriteLine("vui long nhap lai ten: ");
                    String mahoa = Console.ReadLine();
                    JoinDate = DateTime.ParseExact(mahoa, "dd/MM/yyyy", null);
                }
            }
        }

        //contrucotr
        public Employee() { }
        public Employee(String fullname, DateTime birthday, DateTime joindate) : base(fullname, birthday)
        {
            this.JoinDate = joindate;
        }

        //method
        public int getWorkingYear()
        {
            int sonamlamviec = DateTime.Now.Year - this.JoinDate.Year;
            if (sonamlamviec == 0)
            {
                return 1;
            }
            else
            {
                return sonamlamviec;
            }
        }

        //method Override Display
        int salary = 0;
        public override void Display()
        {
            base.Display();
            Console.WriteLine("so ngay tham gia lam viec: " + this.JoinDate.ToShortDateString());
            for (int i = 0; i < this.getWorkingYear(); i += 3)
            {
                salary++;
            }
            Console.WriteLine("Salary level: " + salary);
        }
    }


    //class demo chứa hàm main chạy thực thi chương trình chính
    class Demo
    {
        static void Main(String[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("nhap ten cua ban: ");
            emp.FullName = Console.ReadLine();

            Console.WriteLine("vui long nhap ngay thang nam sinh: ");
            String input = Console.ReadLine();
            emp.Birthday = DateTime.ParseExact(input, "dd/MM/yyyy", null);

            Console.WriteLine("vui long nhap ngay lam viec: ");
            String input2 = Console.ReadLine();
            emp.JoinDate = DateTime.ParseExact(input2, "dd/MM/yyyy", null);

            emp.Display();

            Console.ReadKey();
        }
    }
}
