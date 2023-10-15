using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*bài toán về Partial*/
namespace Lab10_Anonymous
{
     class Demo
    {
        static void Main(String[] args)
        {
            Car car = new Car();

            car.Inputcar();
            
            Console.WriteLine("===========================");
            car.Display();

            Console.ReadKey(); 
        }
    }
}
