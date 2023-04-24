using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapAptech
{
    internal class vonglap
    {
        static void Main(String[] args)
        {
            //cau 01
            int n;
            Console.WriteLine("enter the num n:");
            n = int.Parse(Console.ReadLine());

            int[] mang = new int[n];

            for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("mang:{0}", i);
                    mang[i] = int.Parse(Console.ReadLine());
                }
            int count = 0;

            //cau 02 xuat mang
            foreach (int x in mang)
                {
                    Console.Write(x + " ");
                    count += x;
                }

            //cau03 tinh tbc
            Console.WriteLine("\n");
            float tbc = count / n;
            Console.WriteLine("trung binh cong la:" + count + "/" + n + "= {0:F} ", tbc);


            //cau04 đếm ký tự xuất hiện bao nhiêu lần
            int kiemtra;
            Console.WriteLine("nhap so can kiem tra: ");
            kiemtra = int.Parse(Console.ReadLine());

            int dem = 0;
            foreach (int x in mang)
                {
                    if (kiemtra == x)
                    {
                        dem++;
                    }
                }
            Console.WriteLine("so lan xuat hien la: " + dem);

            //cau 05 thay the gia tri vua kiem tra bang 100
            for(int i =0; i < n; i++)
            {
                if (mang[i] == kiemtra)
                {
                    mang[i] = 100;
                }
            }
            Console.WriteLine("chuoi sau khi thay the 100");
            //xuat thong tin lai lan nua
            foreach(int x in mang)
            {
                Console.Write(x + " ");
            }

         //cau 06 kiem tra so nguyen to trong mang
            Console.WriteLine("\n");
            Console.WriteLine("so nguyen to trong ma la: ");
            for (int i = 0; i < n; i++)
            {
                if (mang[i] == 2 || mang[i] ==1)
                {
                    Console.Write(mang[i] + " ");
                }
                else if (mang[i] > 2)
                {
                    bool isPrime = true;
                    for (int j = 2; j < mang[i]; j++)
                    {
                        if (mang[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.Write(mang[i] + " ");
                    }
                }
            }


            //cau 07 sap xep mang
            Console.WriteLine("\n");
            Array.Sort(mang);
            Console.Write(mang + " ");
            foreach(int x in mang)
            {
                Console.Write(x + " ");
            }


            Console.ReadKey();

        }
    }
}
