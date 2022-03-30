using System;
namespace helloW
{
    class program
    {
        static void Main(String[] args)
        {
            int X = 100;
            double diemSo = 10.5;
            string tenHo = "lập trình c# cơ bản";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // hàm dùng để gõ tiếng việt có dấu

            Console.WriteLine("gia tri x la:{0}, diem so la :{1}, ten ho la:{2}", X, diemSo, tenHo);
            Console.ReadKey();
            /*có thể sử dụng Consoel.ReadLine();*/
        }
    }
}