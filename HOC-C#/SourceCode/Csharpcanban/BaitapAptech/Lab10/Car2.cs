using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Anonymous
{
    partial class Car
    {
        private DateTime buy_date;

        public DateTime BuyDate
        {
            get { return buy_date; }
            set
            {
                buy_date = value;
            }
        }


        // method Name IsWarranty
        public bool isWarranty()
        {
            // nếu xe quá 3 năm xem hết hạn
            DateTime today = DateTime.Now;
            if (today >= BuyDate.AddYears(3))
            {
                return false;
            }
            return true;
        }

        // method inpur car
        public void Inputcar()
        {
            Console.WriteLine("nhap vao ten xe: ");
            Name = Console.ReadLine();
            Console.WriteLine("nhap vao mau xe: ");
            Color = Console.ReadLine();
            Console.WriteLine("nhap vao maker: ");
            Maker = Console.ReadLine();

            Console.WriteLine("nhap vao ngay mua xe: ");
            String input = Console.ReadLine();
            BuyDate = DateTime.ParseExact(input,"dd/MM/yyyy",null);
        }

        // method display
        public void Display()
        {
            Console.WriteLine("ten cua xe la:  " + Name);
            Console.WriteLine("mau xua xe:  " + color);
            Console.WriteLine("maker cua xe:  " + Maker);
            Console.WriteLine("ngay mua:  " + BuyDate);
            if (isWarranty())
            {
                Console.WriteLine("Xe con bao hanh");
            }
            else
            {
                Console.WriteLine("xe qua 3 nam het han bao hanh");
            }

        }



    }
}
