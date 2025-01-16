//on tập về interface => nó cũng tương tự với abstrat tuy nhiên nó linh hoạt hơn
//=> có thể đa kế thừa trong lập trình
//=> khi override trong class ke thua thi khong can dung tk override như với class abstract
//=> access modifier mặc định là public không cần khai báo thêm
//==> cũng như abstract thì khai báo với interface ta sẽ dùng tên interface kém theo
using System;
public interface IAnimal{
   public void eat();
   public void run();
}


//cac class ke thua inerface trien khai nhu sao
public class Bear : IAnimal{
    string name;
    //contructor
    // public Bear(string name){

    // }

    //get and set
    public string Name{
        get{return name;}
        set{name = value;}
    }

    public void eat(){
        Console.WriteLine("Bear keu goam goam");
    }


    public void run(){
        Console.WriteLine("Bear run voi toc do 60km/h");
    }
}