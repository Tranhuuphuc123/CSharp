// bai nay ôn tập về tính chất của CSharp
using System;


//**************1 tính trừu tượng Abstract*****************

// public abstract class Animal{
//     public abstract void MakeSound();
// }


// public class Cat : Animal {
//     public override void MakeSound(){
//         Console.Write("Meow Mewo");
//     }
// }



//***********2 tính kế thừa*****************
public class Animal
{
    public string? _name;
    public int _age;

    //contructor
    public Animal(){

    }

    //contructor
    public Animal(string name, int age){
        _name = name;
        _age = age; 
    }

    //get set
    public string? Name{
        get{return _name;}
        set{_name = value;}
    }

    public int Age{
        get{return _age;}
        set{_age = value;}
    }

    //method
    public virtual void MakeSound(){
        Console.Write("Animal makes a sound");
    } 
}


// lớp kế thùa 
public class Dog : Animal{
    //ghi de method của lop cha Animal
    public override void MakeSound()
    {
       Console.Write("dog makes a sound: gau gau gau");
    }
}


//