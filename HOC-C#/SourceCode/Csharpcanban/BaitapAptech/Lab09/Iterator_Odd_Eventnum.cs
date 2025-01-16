using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*dùng ngon ngữ đánh dấu Iterator đế đánh dấu các số chẵn lẻ và in ra nó*/
namespace Lab09
{
    public class getNum
    {
        // IEnumerable là một interface trong namespace System.Collection.Generic có sẵn

        // funtion lấy in ra các số chẵn đc đánh dấu với iterator(yield)
        public static IEnumerable<int> Odd(){
            for(int i =0; i <=10; i+=2)
            {
                yield return i;
           }
       }


        // function lấy in ra các số lẻ đc đánh dấu với iterator(yield )
        public static IEnumerable<int> Even()
        {
            for (int i = 1; i <= 10; i += 2)
            {
                yield return i;
            }
        }
    }




    internal class Iterator_Odd_Eventnum
    {
        static void Main(String[] arhs)
        {
            // dùng foreach chạy ctrinh gọi class.method
            foreach(int arr in getNum.Odd())
            {
                Console.WriteLine(arr);
            }


            Console.WriteLine("\n");

            // dùng foreach chạy ctrinh gọi class.method
            foreach (int arr in getNum.Even())
            {
                Console.WriteLine(arr);
            }
        }
    }
}
