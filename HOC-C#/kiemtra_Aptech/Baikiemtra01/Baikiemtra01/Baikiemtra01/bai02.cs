﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Baikiemtra01
{
  /*class Animal*/

    public abstract class Animal
    {
        private String _Name;
        private int _Age;

        //get and set
        public String Name
        {
            get { return _Name; }
            set
            {
                Regex re = new Regex("^[A-Za-z ]+$");
                if (re.IsMatch(value))
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("vui long nhap lai ten dong vat: ");
                    Name = Console.ReadLine();
                }
            }


        }

        public int Age
        {
            get { return _Age; }
            set
            {
                if (value > 0)
                {
                    _Age = value;
                }
                else
                {
                    Console.WriteLine("tuoi khong dat yeu cau vui long nhap lai");
                    Age = int.Parse(Console.ReadLine());
                }
            }
        }

        //contructor
        public Animal() { }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }

        //method Sound
        public abstract void Sound();
        
    }






    /*class UnderwaterAnimal */
    //propertype of Waterkind
    public enum WaterType
    {
        Freshwater,
        Saltwater
    }

    class UnderwaterAnimal : Animal
    {

       private WaterType _waterKind;

        //get and set
        public WaterType WaterKind
        {
            get { return _waterKind; }
            set
            {
                if (value == WaterType.Freshwater || value == WaterType.Saltwater)
                {
                    _waterKind = value;
                }
                else
                {
                    Console.WriteLine("khong hop lee.");
                    while (true)
                    {
                        Console.Write("vui ông nhap lai loai dong vat: ");
                        var input = Console.ReadLine();
                        if (Enum.TryParse<WaterType>(input, out var waterType))
                        {
                            _waterKind = waterType;
                            break;
                        }
                       
                    }
                }
            }
        }

        //contructor
        public UnderwaterAnimal():base() { }
        public UnderwaterAnimal(String name,int age,WaterType waterkind):base(name,age)
        {
            this.WaterKind = waterkind;
        }

        public override void Sound()
        {
            Console.WriteLine("am thanh dong vat duoi nuoc");
        }

    }
    

    //class TerrestrialAnimal
    class TerrestrialAnimal : Animal
    {
        private String _Residence;


        //get and set
        public String Residence
        {
            get { return _Residence; }
            set
            {
                _Residence = value;
            }
        }

        //contructor
        public TerrestrialAnimal() :base(){ }
        public TerrestrialAnimal(String name, int age,String residence):base(name,age)   
        {
                this.Residence = Residence;
        }

        public override void Sound()
        {
            Console.WriteLine("mo ta tieng keu cua dong vat");
        }
    }



    //class tiger
    class Tiger : TerrestrialAnimal
    {
        public Tiger() : base() { }
        //contructor
        //cách khai báo không tham số


        public override void Sound()
        {
            Console.WriteLine("Tiger gam vang ca nui rung");
        }
    }

    //class Crocodile
    class Crocodile : TerrestrialAnimal
    {
        //contructor
        public Crocodile() : base() { }

        public override void Sound()
        {
            Console.WriteLine("Crocodile an minh duoi bun");
        }
    }



    //class Demo
    class Demo
    {
        static void Main(String[] args)
        {
            Tiger tiger = new Tiger();
            Console.WriteLine("nhap ten dong vat: ");
            tiger.Name = Console.ReadLine();

            Console.WriteLine("nhap tuoi dong vat: ");
            tiger.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap noi hoat dong : ");
            tiger.Residence = Console.ReadLine();

            Console.WriteLine("========thong tin cua " + tiger.Name + "============");
            ArrayList list = new ArrayList();
            list.Add(tiger);

            //xuất hông tin
            foreach(Tiger item in list)
            {
                Console.WriteLine("Ten dong vat: " + item.Name);
                Console.WriteLine("Tuoi dong vat: " + item.Age);
                Console.WriteLine("Noi hoat dong: " + item.Residence);
            }
            
            tiger.Sound();

        }
    }
    //end program
}
