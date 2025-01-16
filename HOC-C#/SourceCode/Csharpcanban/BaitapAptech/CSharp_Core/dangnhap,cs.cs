using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*dạng bài tập kiểm tra tên đăng nhập và mật khẩu:*/
namespace CSharp_Core
{

    // class dang nhap
    class dangnhap
    {
        public bool kiemtradangnhap(String User, String Pass)
        {
            if(User == "A011" && Pass=="Huuphuc123@")
            {
                return true;
            }
            return false;
        }
    }


    // class Texter
     class Demo
    {
        static void Main(String[] args)
        {
            String UserName, Passwword;
            Console.WriteLine("======================");
            dangnhap dn = new dangnhap();

            // tao bien dem de xac nhan qua 
            int count = 0;

            do
            {
                Console.WriteLine("Nhap vao UserName: ");
                UserName = Console.ReadLine();

                Console.WriteLine("nhap vao PassWord: ");
                Passwword = Console.ReadLine();
                count++;

            }while((dn.kiemtradangnhap(UserName,Passwword) != true) && count!=3);

            if (dn.kiemtradangnhap(UserName, Passwword) == true)
            {
                Console.WriteLine("Succefully! Ban da dang nhap thanh cong");
            }else if(count == 3)
            {
                Console.WriteLine("Ban da dang nhap qua 3 lan, tai khoan bi khoa 5p");
            }
           
           

            Console.ReadKey();
        }
    }
}
