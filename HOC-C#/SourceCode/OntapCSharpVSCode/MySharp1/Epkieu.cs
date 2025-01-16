// tiem hieu ve ep kieu trong csharp
using System;
class Epkieu{
    //trong ep kieu se dung hai kieu du lieu chinh la inParse va convert
    public void epkieuType(){
        //01 - ep keiu ngam dinh
        int a = 10;
        float b = a;
        Console.WriteLine("ket qua b: " + b) ;

        //02 - ep kieur tuong minh
        double c = 10.25;
        int d = (int) c;
        Console.WriteLine("ket qua d: " + d) ;

        //03- ep kieu voi method , lop ho tro
        string e = "123";
        int result = Convert.ToInt32(e);
        Console.WriteLine("ket qua chuyen doi chuoi e thanh so nguyen: " + result);

    }
}