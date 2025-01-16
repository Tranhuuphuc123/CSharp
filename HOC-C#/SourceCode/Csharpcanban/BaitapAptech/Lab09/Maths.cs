using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*viết chương trình tạo một lớp turruuf tượng   kiểu generic để thực thi toán tử công và toán tử trừ
 */
namespace Lab09
{

   abstract class Maths<T>
    {
        public T num1, num2;
        // method abstract Add.. do không có tham chiếu nên không truyền ref
        public abstract T Add(T num1, T num2);
        // method abstarct Sub
        public abstract T Sub(T num1, T num2);
        // method abstract Div
        public abstract T Div(T num1, T num2);
    }


    // make subclass MathInt
    class MathInt : Maths<int>
    {
        public override int Add(int num1, int num2) {
            return num1 + num2;
        }

        public override int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public override int Div(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Divide 0");
                return -1;
            }
            else
            {
                return num2 / num2;
            }
        }
    }


    // texter chương trình
    class Demo
    {
        static void Main(String[] args)
        {
            MathInt m = new MathInt();
            int a, b;

            Console.WriteLine("nhap vao so a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao so b: ");
            b = int.Parse(Console.ReadLine());


            // thực thi
            Console.WriteLine("ket qua phep Add =  " + a + "+" + b + "= " + m.Add(a, b));
        }
    }
}
