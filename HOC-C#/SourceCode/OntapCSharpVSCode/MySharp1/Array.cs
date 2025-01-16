//bai tap tiem hieu ve mang trong csharp
using System;

class Mang{
    /*method nhap mang*/
    public int[] Nhapmang(){
        //khai bao mang trong csharp
        int[] arr = [1,2,3,4,5,6];

        //ta co the su dung t/c mang de nhap tu ban phim
        Console.WriteLine("nhap so phan tu mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] myArr = new int[n];


        //nhap tung phan tu mang 
        Console.WriteLine("nhap n phan tu mang: ");
        for(int i =0; i< n; i++){
            Console.WriteLine("phan tu " + i + ": ");
            myArr[i] = Convert.ToInt32(Console.ReadLine());
        } 

        return myArr;
    }



     /*method xuat mang*/
    public void Xuatmang(int[] arr){
        //xuat mang
        Console.WriteLine("gia tri tung mang la");
        foreach(int value in arr){
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

}