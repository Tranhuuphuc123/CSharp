using System;
using System.Text.RegularExpressions;

/*class 1: Person lam class chu dao*/
class Person
{
    // Các trường (fields) riêng tư
    private string _hoTen;
    private DateTime _ngaySinh;

    // Các thuộc tính
    public string hoTen
    {
        get { return _hoTen; }
        set
        {
            // Kiểm tra tên bằng biểu thức chính quy (regex)
            Regex re = new Regex("^[A-Za-z ]+$"); // Cập nhật regex
            if (re.IsMatch(value))
            {
                _hoTen = value;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập tên đúng ký tự cho phép: ");
                _hoTen = Console.ReadLine();
            }
        }
    }

    public DateTime ngaySinh
    {
        get { return _ngaySinh; }
        set
        {
            if (value.Year <= DateTime.Now.Year)
            {
                _ngaySinh = value;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập lại năm cho đúng (dd/MM/yyyy): ");
                string input = Console.ReadLine();
                _ngaySinh = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            }
        }
    }

    // Hàm khởi tạo
    public Person() {}

    public Person(string hoTen, DateTime ngaySinh)
    {
        this.hoTen = hoTen;
        this.ngaySinh = ngaySinh;
    }

    // Phương thức để tính tuổi
    public int layTuoi()
    {
        int tuoi = DateTime.Now.Year - this.ngaySinh.Year;
        if (DateTime.Now.DayOfYear < this.ngaySinh.DayOfYear)
        {
            tuoi--;
        }
        return tuoi > 0 ? tuoi : 1;
    }

    // Phương thức hiển thị
    public virtual void HienThi()
    {
        Console.WriteLine("Tên của bạn là: " + this.hoTen);
        Console.WriteLine("Tuổi của bạn là: " + this.layTuoi());
    }
}



/*class 2: class ke thua tinh chat cua person*/
class Employee : Person{
    private DateTime _joinDate;

   //get and set 
   public DateTime joinDate{
    get{return _joinDate;}
    set{
        if(value.Year <= DateTime.Now.Year){
            _joinDate = value;
        }else{
            Console.WriteLine("vui lap nhap lai ngay vao lam: ");
            string input = Console.ReadLine();
            _joinDate = DateTime.ParseExact(input, "dd/MM/yyyy",null);
       }
    }
  }

  //contructor
  public Employee(){}
  public Employee(string hoTen, DateTime ngaySinh, DateTime joinDate) : base(hoTen, ngaySinh){
    this.joinDate = joinDate;
  }

  //method getWorkingYear
  public int getWorkingYear(){
    int soNamLamViec = DateTime.Now.Year - this.joinDate.Year;
        if (DateTime.Now.DayOfYear < this.joinDate.DayOfYear)
        {
            soNamLamViec--; // Trừ đi một năm nếu ngày vào làm chưa đến trong năm hiện tại
        }
        return soNamLamViec > 0 ? soNamLamViec : 1;
  }

    //display
    public override void HienThi()
    {
        base.HienThi();// ke thua lai cac muc hien thi o class Person
        Console.WriteLine("so nam tham gia lam dc la: " + this.getWorkingYear());

    }
}