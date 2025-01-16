using System;

class Nhapxuat{

    public void Nhapten(){
         // Nhập tên từ người dùng
        Console.Write("Vui lòng nhập tên của bạn: ");
        string? name = Console.ReadLine();

        // Xuất tên ra màn hình
        Console.WriteLine("Xin chào, " + name + "!");
    }
   
}