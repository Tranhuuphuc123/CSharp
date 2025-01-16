using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Bài tập vẽ hình tùy ý đa dạng trong lập trình C# thay vì sử dụng vòng lặp for và mảng thông thường ta sử dựng mảng 2 chiều 
 nhập mảng 2 chiều các ký tự mong muốn qua đó ta khooing chỉ tao đc một hỉnh tam giác mà có thể tạo bất kỳ hình ảnh nào ta muôn
thoog qua mảng 2 chiều ký tự
 */
namespace CSharp_Core
{
    class Vehinhdadang
    {
        static void Main(String[] args)
        {
            // xuất tam giá tùy ý theo mảng 2 chiều
            int i, j;
            char[,] arr = new char[7, 7];

            //nhap mang ky tu
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 7; j++)
                {
                    Console.Write("arr[" + i + "," + j + "]: ");
                    arr[i, j] = Console.ReadKey().KeyChar;
                    Console.Write("\t");

                }
            }
            Console.Write("\n\n");
            Console.WriteLine("\n\n");



            // xuat dang tam giac hay hinh dang bat ky muon thiet ke

            for (i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for( j = 0; j < 7; j++)
                {
                    Console.Write("{0}\t", arr[i,j]);
                }
            }
            Console.WriteLine();

        }
    }
}
