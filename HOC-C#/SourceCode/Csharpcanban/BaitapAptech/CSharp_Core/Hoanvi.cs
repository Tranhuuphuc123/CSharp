using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Hoán vị là dạng bài tập trao đổi giá trị cơ bản trong bất kỳ ngôn ngữ lập trình nào
qua đó ta làm quen với cấu trúc và cách thức chuyển đổi một giá trị và trao đổi với nhau giữa 3 
giá trị: bài toán đoán đơn giản kiểu có value 1 =a, value 2 =b, làm sao để value1=b, value 2 =a.. làm 
sao để hoán đổi nó...
 */
namespace CSharp_Core
{
   class Hoanvi
    {
        static void Main(String[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("nhap gia tri cho num 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri cho num 2: ");
            num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("gia tri ban dau num1: " + num1);
            Console.WriteLine("gia tri ban dau num2: " + num2);

            /* cachs thức hoán vị trao đổi giá trị\
             láy một biến tạm lưu giá trị 1 sau đó lấy value num2 gán cho num1
            lấy giá trị tạm chứa lúc nãy gán cho num1 vậy là num1=num2 và num2=num1
             */

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("===================");

            Console.WriteLine("gias tri sau hoan doi:");
            Console.WriteLine("gias tri num1 sau hoan doi: " + num1);
            Console.WriteLine("gias tri num2 sau hoan doi: " + num2);

        }     
    }
}
