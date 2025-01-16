using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//*Học cách sử dụng ArayList*/
namespace Lab08_Delegate_ArrayList
{
   class bai04_ArrayList
    {
        static void Main(String[] args)
        {
            ArrayList arr = new ArrayList(3);
            arr.Add(10);
            arr.Add(20);
            arr.Add(30);
            arr.Add(40);

            // Dissplay
            Console.WriteLine("============");
            Console.WriteLine("xuat mang ArrayList");

            foreach(int list in arr)
            {
                Console.WriteLine(list + " ");
            }

            //thêm phần tử mới ở vị trí Possition chỉ định
            int x, p;
            Console.WriteLine("nhap vao phan moi: ");
            x = int.Parse(Console.ReadLine());
            
            bool Iskiemtra = true;
            do
            {
                if (arr.Contains(x))
                {
                    Console.WriteLine("gia tri : " + x + " bi trung lap:");
                    Console.WriteLine("Nhap lai: ");
                    x = int.Parse(Console.ReadLine());
                }
                else
                {
                    Iskiemtra = false;

                }

            } while (!Iskiemtra);


            // do mảng bắt đầu băng 0 nên lúc nào nó cũng giựt lại 1 số
            Console.WriteLine(" vi tri Possition them vao: ");
            p = int.Parse(Console.ReadLine());
            arr.Insert(p - 1, x);
            Console.WriteLine("chen x" + x + " vao vitri: " + (p - 1));

            // Display again
            foreach (int list in arr)
            {
                Console.WriteLine(list + " ");
            }

           
            Console.ReadKey();
        }
    }
}
