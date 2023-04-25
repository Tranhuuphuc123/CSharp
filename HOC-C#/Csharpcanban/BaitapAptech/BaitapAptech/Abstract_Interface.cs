using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapAptech
{
    interface IAnimal
    {
        void eat();
        void run();
    }

    interface IBirth
    {
        void eat();
        void fly();
    }

    class Bear : IAnimal
    {
        String name;

        //contructor
        public Bear(String  name){
            this.name = name;
            Console.WriteLine();
            Console.WriteLine("Bear name is: " + name);
        } 

        public  void eat()
        {
            Console.WriteLine("Bear eat honey");
        }

        public void run()
        {
            Console.WriteLine("Bear eun is fat with 60km/h");
        }
    }


    class Eagle : IBirth
    {

        String name;
        //contructor
        public Eagle(String name)
        {
            this.name = name;
            Console.WriteLine();
            Console.WriteLine("Eagle name is: " + name);
        }
        public void eat()
        {
            Console.WriteLine("Eagle eat grass");
        }

        public void fly()
        {
            Console.WriteLine("Eagle fly ont the sky");
        }
    }


    class Bat : IAnimal, IBirth
    {
        String name;

        //contructor
        public Bat(string name)        {
            this.name = name;
            Console.WriteLine();
            Console.WriteLine("Bat name is: " + name);
        }

        public void run()
        {
            Console.WriteLine("Bat can run as animal");
        }

        public void fly()
        {
            Console.WriteLine("Bat can fly as Birth ");
        }

        //tới thừa kế hai method Interface là eat, tuy nhiên để phân biêt là eat() của IAnimal hay IBirth
        //-> ta làm như sau:
         void IAnimal.eat(){
            Console.WriteLine("Bat eat mosquito");    
        }
        void IBirth.eat()
        {
            Console.WriteLine("Bat eat fruit");
        }
        

    }

    class Demo
    {
       static void Main(String[] args)
        {
            Bear bear = new Bear("Loco");
            bear.run();
            bear.eat();

            Eagle eagle = new Eagle("hana");
            eagle.eat();
            eagle.fly();


            // lớp Bat vừa là động vật vừa là chim nó sẽ gặp trở ngại và triển khai method eat() như thế nào để không bị nhầm
            Bat bat = new Bat("gogo");
            bat.run();
            bat.fly();
            //hai thuộc tính trên dễ dàng phân biệt cho các lớp interfcae nhưng với eat()thì cần khai báo cụ thể nếu không sẽ lỗi
            ((IAnimal)bat).eat();
            ((IBirth)bat).eat();
        }
    }
}
