// tiem hieu ve mang 2 chieu trong  csharp
using System;

class Mang2chieu{

    /*method nhap mang*/
    public int[,] Nhapmang(){
       // khai bao mang hai chieu co ban
       int [,] m = {
        {1,2},
        {3,4},
        {5,6}
       };

       //nhap mang hai chieu tu ban phim
       Console.WriteLine("nhap vao sl row va col: ");
       Console.WriteLine("nhap so luong cot: ");
       int a = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("nhap so luong hang: ");
       int b = Convert.ToInt32(Console.ReadLine());

       int[,] myArr= new int[a,b];

       Console.WriteLine("nhap tu phan tu hang va cot trong mang hai chieu ");
       for(int i=0; i<a;i++ ){
        for(int j=0; j<b;j++){
            Console.WriteLine("phan tu: " + i + " - " +  j);
            myArr[i,j] = Convert.ToInt32(Console.ReadLine());
        }
       }

       return myArr;

    }

    /*Mehod xuat mang */
    public void Xuatmang(int[,] arr){
        int rows = arr.GetLength(0); // Lấy số hàng của mảng
        int cols = arr.GetLength(1); // Lấy số cột của mảng

        // Xuất mảng hai chiều
        Console.WriteLine("Giá trị của mảng hai chiều là: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + "\t"); // Xuất từng phần tử với dấu tab
            }
            Console.WriteLine(); // Xuống dòng sau khi in hết một hàng
        }
    }


}