using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Nhập 2 số bất kỳ sao đó nhập phép tính mong muốn: + - * /... thì thực hiện phép toán đó
 */

namespace CSharp_Core
{
     class Nhappheptoan
    {
        static void Main(String[] args)
        {
            int a, b;
            char pheptoan;
            Console.WriteLine("nhap so a: ");
            a =int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap vao phep tinh: ");
            pheptoan = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (pheptoan)
            {
                case '+':
                    Console.WriteLine("phep cong la: " + a + "+" + b + "=" + (a+b));
                    break;

                case '-':
                    Console.WriteLine("phep cong la: " + a + "-" + b + "=" + (a - b));
                    break;

                case '*':
                    Console.WriteLine("phep cong la: " + a + "*" + b + "=" + (a * b));
                    break;

                case '/':
                    Console.WriteLine("phep cong la: " + a + "+" + b + "=" + (a / b));
                    break;
                
               default:
                    Console.WriteLine("phep tinh khong nam trong tinh toan");
                    break;
                    
            }


            Console.ReadKey();
        }
    }
}
