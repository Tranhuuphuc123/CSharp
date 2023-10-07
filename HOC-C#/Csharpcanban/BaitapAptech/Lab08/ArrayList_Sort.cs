using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*tiềm hiểu về collection ArrayList- thuộc tính Sort*/

namespace Lab08_Delegate_ArrayList
{
    // tạo class con người person
    class Person
    {
        private String name;
        private int age;

        // get and set
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }



        //contrucotr
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // method toString
        public override string ToString()
        {
            return  "thong tin: " + this.Name + " " + this.Age + "\n";
        }
    }



    // class sắp xếp mẳng sortPerson : interface IComparer
    class sortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person.
            Person p1 = x as Person;
            Person p2 = y as Person;


            // tiến hành bắt lỗi ép kiểu nếu như truyền vào không phải là value của một con người
            if(p1 == null || p2 == null)
            {
                throw new InvalidOperationException(); // thuộc tính kiểm tra ép kiểu trong exception
            }
            else
            {
                if (p1.Age > p2.Age)
                {
                    return 1; // đc hiểu là p1 sẽ thỏa đk đứng trc p2
                }else if(p1.Age == p2.Age)
                {
                    return 0; // đc hiểu là 2 giá trị trùng nhau
                }
                else
                {
                    return -1; // được hiểu là -1 chấp thuận đk thỏa để p1 nừm sau p2
                }

            }

        }
    }



    // class Demo text chương trình
    public class Demo
    {
        static void Main(String[] args)
        {
            ArrayList ListItem = new ArrayList();
            Person p1 = new Person("phuc", 18);
            Person p2 = new Person("Phuong", 21);
            Person p3 = new Person("Long", 19);

            ListItem.Add(p1);
            ListItem.Add(p2);
            ListItem.Add(p3);

         
            //tiến hành xuất mảng
            foreach(Person item in ListItem)
            {
                Console.Write(item.ToString());
            }

            Console.WriteLine("====================");

            // tiến hành sắp xếp mảng
            sortPerson sp = new sortPerson();
            ListItem.Sort(sp);

            Console.WriteLine("==========mang sau khi sap xep=========");
            foreach (Person item2 in ListItem)
            {
                Console.Write(item2.ToString());
            }

            Console.ReadKey();
        }
    }
}
