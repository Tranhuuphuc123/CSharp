using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*tiềm hiểu về Delegrate*/
namespace Lab08_Delegate_ArrayList
{

    // method Delegrate? tiềm hiệu lại sao
   public  delegate void Show();

    class Phuc
    {
        public void ShowOdd() {
            for (int i = 1; i <= 20; i+=2)
            {
                Console.Write(i + " ");
            }
        }

        public void ShowEven()
        {
            for (int i = 2; i <= 20; i+=2)
            {
                Console.Write(i + " ");
            }
        }
    }

  

    class bai02_Delegrate
    {
        static void Main(String[] args)
        {

            // thực thi Delegate
            Console.WriteLine("thực thi delegate");
            Phuc p = new Phuc();
            Show show = new Show(p.ShowOdd);
            show();
    
            Console.WriteLine("\n\n");
            show = new Show(p.ShowEven);
            show();
            Console.ReadKey();
        }    

    }
}
