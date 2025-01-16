using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithigiuaky
{   
     class Month_Text
    {
        static void Main(string[] args)
        {
            string[] months = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            string month;
            do
            {
                Console.Write("nhap vao ten thang (y/c: nhap ten thuong 3 ky tu dau): ");
                month = Console.ReadLine().ToLower();
            } while (!months.Contains(month));

            Console.WriteLine("\n");
            switch (month)
            {
                case "jan":
                case "feb":
                case "mar":
                    Console.WriteLine(" thang "+  month + " la quy dau nam");
                    break;
                case "apr":
                case "may":
                case "jun":
                    Console.WriteLine(" Thang " + month + "la quy hai cua nam");
                    break;
                case "jul":
                case "aug":
                case "sep":
                    Console.WriteLine(" Thang " + month + "la quy ba cua nam");
                    break;
                case "oct":
                case "nov":
                case "dec":
                    Console.WriteLine(" Thang " + month + "la quy bon cua nam");
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine(" Thang ban nhap khong hop le!");
                    break;
            }


            Console.ReadKey();
            
        }

    }
}
