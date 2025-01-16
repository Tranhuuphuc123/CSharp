/*KIẾN THỨC BỔ SUNG VỀ INDEXER
 => Indexer trong c# cho phép các đối tượng truy cập như một mảng
 nhanh gọn linh hoạt hơn thay vì phải khai báo các mảng riêng lẻ rồi 
 nhập mảng rồi mới xuất mẳng thì indexer đơn giản và linh hoạt hơn.
 => Indexer hoạt động giống chỉ mục trong c/c++
 => Khai bao Indexer tương ứng nhu khai bao mot properties (nó cũng có get set)
 cu phap de khai bao chi ra no là mot Indexer la this[type name]
     vd: this[int index]

   + Cách hoạt động:
        ++ Bạn khai báo một indexer với cú pháp this[int index]. 
        this ở đây đại diện cho đối tượng hiện tại, và int index 
        là chỉ số của phần tử mà bạn muốn truy cập.

        ++ Phần get được sử dụng để truy cập giá trị của một phần 
        tử trong mảng data. Khi bạn viết indexer[0], nó sẽ trả về 
        giá trị data[0].

        ++ Phần set được sử dụng để gán giá trị cho một phần tử. 
        Khi bạn viết indexer[0] = 1;, nó sẽ gán data[0] bằng 1.

    + Ưu thế của Indexer:
      ++ truy cập dễ dàng thay vì viết các method nhập mảng riêng dài dòng
      ++  với Indexer thì bạn chỉ cần khởi tạo mang và gáng giá trị là nó đã thành
      một mảng với các giá trị đc gán
      ++ tăng tính trực quan: giúp mã nguồn dễ đọc hơn
      ++ tích hợp chặt chẽ với các lớp

    + Ứng dụng của Indexer:
      ++ dùng indexer để truy cập dánh sách khách hàng
      ++ ma trận
      .....  
*/
using System;
class Indexer{
    // khai bao mang indexer
    private string[] data = new string[10];

    //this[index]: chinhs la khai bao chi muc nhu mot thuoc tinh properties bt
    public string this[int index]{
        get{return data[index];}
        set{data[index] = value;}
    }

    // Thuộc tính để lấy số lượng phần tử của mảng
    public int Length {
        get { return data.Length; }
    }
}

