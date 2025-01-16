using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* tiềm hiểu về Generic*/
namespace Generic
{
    class Generic
    {
      /*ref là từ khóa dùng để truyền tham số theo tham chiếu (by reference)
        => khi bạn truyền một tham số theo tham chiếu, bạn đang truyền tham chiếu tới biến gốc,
        không phải là một bản sao của giá trị. Điều này có nghĩa là bất kỳ thay đổi nào đối với 
        tham số trong phương thức cũng sẽ ảnh hưởng đến biến gốc:*/
        public void Swap<T>(ref T value1, ref T value2)
        {
            // hàm chuyển đổi
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
   
     class Demo
    {
        static void Main(String[] args)
        {
            int num1 = 10, num2 = 20;
            // gọi class generic
            Generic a  = new Generic();

            Console.WriteLine("gia tri ban dau:\n num1 = {0} \t num2 = {1}", num1, num2);
            // giá trị sau chuyển đổi
            a.Swap<int>(ref num1, ref num2);
            Console.WriteLine("gia tri ban dau:\n num1 = {0} \t num2 = {1}", num1, num2);


            float f1 = 10.5f, f2 = 20.7f;
            Console.WriteLine("gia tri ban dau:\n num1 = {0} \t num2 = {1}", f1, f2);
            // giá trị sau chuyển đổi
            a.Swap<float>(ref f1, ref f2);
            Console.WriteLine("gia tri ban dau:\n num1 = {0} \t num2 = {1}", f1, f2);


            String s1 = "Phuc", s2 = "Huu";
            Console.WriteLine("gia tri ban dau:\n num1 = {0} \t num2 = {1}", s1, s2);
            // giá trị sau chuyển đổi
            a.Swap<String>(ref s1, ref s2);
            Console.WriteLine("gia tri ban dau:\n num1 = {0} \t num2 = {1}", s1, s2);


            Console.ReadKey();

        }
    }
}
