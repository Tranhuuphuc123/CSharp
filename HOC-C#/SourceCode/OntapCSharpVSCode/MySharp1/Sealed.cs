// tim hieu ve sealed class trong csharp
//=> class ma co sealed thi ngan ke thua ngan khong ghi de method bao mat toan dien
using System;
sealed class SealedClass{
    public int X { get; set; }
    public int Y { get; set; }

    public int Sum() => X + Y;
}

// các class bt khác sẽ khong kế thừa đc class có sealed

// class subclass : SealedClass {

// }
