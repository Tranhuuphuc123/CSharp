using System;

namespace ReviewBasic
{
   class Text
   {
      static void Main(string[] args){

        /*========01/Phần Generic==========*/
            // Console.WriteLine("Vi du minh hoa Generic trong C#");
            // Console.WriteLine("-------------------------------------");
             
            // //khai bao mot mang cac so nguyen
            // TestGeneric<int> intArray = new TestGeneric<int>(5);
            // //thiet lap cac gia tri
            // for (int c = 0; c < 5; c++)
            // {
            //     intArray.setItem(c, c * 5);
            // }
            // //lay va hien thi cac gia tri
            // for (int c = 0; c < 5; c++)
            // {
            //     Console.Write(intArray.getItem(c) + " ");
            // }
            // Console.WriteLine();

            // // giúp dừng àn hình không tắt
        
        
        
        
        /**********Delegate****************/
            // thực thi Delegate
            Console.WriteLine("thực thi delegate");
            Phuc p = new Phuc();
            // gọi khưởi tạo delegate
            Show show = new Show(p.ShowOdd);
            show();
    
            Console.WriteLine("\n\n");
            show = new Show(p.ShowEven);
            show();
            Console.ReadKey();



         Console.ReadKey();
      }
   }
}