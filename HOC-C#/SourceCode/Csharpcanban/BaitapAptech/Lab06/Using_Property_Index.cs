using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*luyện tâp thuộc tính của lớp trừu tượng
 using Property - indexs
 */

// làm bài tập 03-L6.pdf
namespace Lab06
{
    class Worker
    {
        //make filed in C#
        private string code;
        private string name;
        private int level;


        //get and set Acessor of Code
        public string Code
        {
            get { return code; }
            set
            {
                if (value != " ")
                {
                    code = value;
                }
                else
                {
                    Console.WriteLine("yeu cau nhap lai khong duoc trong");
                    Code = Console.ReadLine();
                }
            }
        }
        //get and set Accessor of Name
        public string Name
        {
            get { return name; }
            set
            {
                Regex re = new Regex("^[A-Za-z ]+$");
                if (re.IsMatch(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("yeu cau nhap lai khong duoc sai ten");
                    name = Console.ReadLine();
                }
            }
        }

        //get and set Accessor of Level
        public int Level
        {
            get { return level; }
            set
            {
                if (level >= 0)
                {
                    level = value;
                }
                else
                {
                    Console.WriteLine("nhap lai level: ");
                    Level = int.Parse(Console.ReadLine());
                }
            }
        }

        //indexers in C#
        // dùng indexẻ khai báo giá trj mảng lưu trữ thời gian 7 ngày trong tuần
        private float[] timekeeping = new float[7];
        public float this[int i]
        {
            get { return timekeeping[i]; }
            set
            {
                timekeeping[i] = value;
            }
        }

        // method display
        public void Display()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Code: " + this.Code);
            Console.WriteLine("Fullname: " + this.Name);
            Console.WriteLine("Level: " + this.Level);
            Console.WriteLine("**************************************************");
        }

        //method checktime ghi nhan so gio lam moi ngay
        public void CheckTime(int day, float hours)
        {
            // this la indexer ghi dai dien ngay cong don so gio lam dc 1 ngay
            this[day] += hours;
        }

        // method tinh tong gio cong cua nhan vien
        public void getHours()
        {
            float total = 0;
            for (int i = 0; i < 7; i++)
            {
                total += timekeeping[i];
            }
        }

        //method tinh luong chi tiet: lg co ban*1500+overshift*20000=salary
        public float getSalary()
        {
            float salary = 0;
            float standart = 0;
            float overshift = 0;

            for (int i = 0; i < 5; i++)
            {
                if (timekeeping[i] <= 8)
                {
                    standart += timekeeping[i];
                }
                else
                {
                    standart += 8;
                    overshift += (timekeeping[i] - 8);
                }
            }
            overshift += timekeeping[5];
            overshift += timekeeping[6];

            salary = standart * 1500 + overshift * 20000;
            return salary;
        }

        // hien thi luong
        public void DisplayTimeKeeping()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(" " + this[i]);
            }
        }
    }



    //class Texter run program
    class Demo
    {
        static void Main(String[] args)
        {
            Worker w = new Worker();
            Console.WriteLine("Input code of worker: ");
            w.Code = Console.ReadLine().Trim();
            Console.WriteLine("Input name of worker: ");
            w.Name = Console.ReadLine().Trim();
            Console.WriteLine("Input level of worker: ");
            w.Level = int.Parse(Console.ReadLine().Trim());

            string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Input total working hours of " + days[i] + " : ");
                w[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Information of workers: ");
            w.Display();
            Console.WriteLine("Working hours form Monday to Sunday:");
            w.DisplayTimeKeeping();

            // thay đổi số giwof làm việc của t7 giả dụ t7 nhập giờ rồi nhưng muốn nhập sai sữa thông tin lại thì làm như sau:
            Console.WriteLine();
            Console.WriteLine("Input the more hours of Saturday: ");
            w.CheckTime(5, float.Parse(Console.ReadLine()));

            Console.WriteLine("Working hours form Monday to Sunday after change:");
            w.DisplayTimeKeeping();

            Console.WriteLine("******* Salary is: " + w.getSalary());

            Console.ReadKey();
        }
    }

}
