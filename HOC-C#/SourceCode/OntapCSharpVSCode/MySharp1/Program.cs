using System;
using System.Net.NetworkInformation;

namespace MySharp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
          /******Mang 1 chieu*******/ 
            // Mang array = new Mang();
            // int[] myArr = array.Nhapmang();

            // //xuat mang
            // array.Xuatmang(myArr);


          /******Mang 2 chieu*******/
            // Mang2chieu m2 = new Mang2chieu();

            // int[,] myArr = m2.Nhapmang();

            // m2.Xuatmang(myArr);


          /******Tinh ke thua Inheritance******/
            // Employee emp = new Employee();
            
            // Console.WriteLine(" nhap ten: " );
            // emp.hoTen = Console.ReadLine();

            // Console.WriteLine("nhap ngay than nam sinh: ");
            // string input = Console.ReadLine();
            // emp.ngaySinh = DateTime.ParseExact(input, "dd/MM/yyyy", null);


            // Console.WriteLine("nhap ngay thang lam viec cua ban: ");
            // string input1 = Console.ReadLine();
            // emp.joinDate = DateTime.ParseExact(input1, "dd/MM/yyyy", null);

            // emp.HienThi();



          /*******abstract lop truu tuong*******/
            // Cho cho = new Cho();
            // cho.Makesound();
            

          /**********interface**********/
            // Bear bear = new Bear();
            // Console.WriteLine("nhap vao ten cua con gau: ");
            // string name = Console.ReadLine();
            // bear.Name = name;
            
            // Console.WriteLine("ten cua con Bear la: " + name);
            // bear.eat();
            // bear.run();


          /***********Indexer chi muc*****************/  
            Indexer indexer =  new Indexer();
            indexer[0] = "Hong";
            indexer[1] = "cuc";
            indexer[2] = "dao";

            for (int i = 0; i< indexer.Length; i++){
              Console.Write(indexer[i] + " ");
            }



          /*****************Xử lý ngoại lệ***********************/
            

            Console.ReadKey();
        }
    }
} 



