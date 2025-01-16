using System.ComponentModel;
using System.Drawing;
// học về kiểu dữ liệu enum
using System;
 class Enum{
    public enum Color{
            red, 
            blue,
            yellow
        }

    //method chon color voi eneum da liet ke o tren
    public void chooseColor(){
        Console.WriteLine("vui long chon mau sac can thiet: 0. red - 1.blue -3.yellow");
        int choose = int.Parse(Console.ReadLine());

        if(choose == (int)Color.red){
            Console.WriteLine("ban vua chon mau do");
        }else if(choose == (int)Color.blue){
            Console.WriteLine("ban vua chon mau xanh da troi");
        }else if(choose == (int)Color.yellow){
            Console.WriteLine("ban vua chon mau vang");
        }
    }


//=> luu y trong enum khong dung toan tu == nen ep kieu ve cung dang 
 }