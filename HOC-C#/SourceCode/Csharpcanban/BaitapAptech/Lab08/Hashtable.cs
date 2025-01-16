using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*tiềm hiểu về cách dùng hashtable trong collection*/

namespace Lab08_Delegate_ArrayList
{
    // xây dựng class Myhash để gán key-value-> xuất ra
    class Myhash
    {
        public static void Main(String[] args)
        {
            // khởi tạo hashtable
            Hashtable hash = new Hashtable();

            // tiến hành Add thêm key-value vào hash để thiết lặp key-value
            hash.Add("K", "Kteam");
            hash.Add("P", "Phuc");
            hash.Add("X", "Xamarin");


            /// xuất cặp key-value mỗi phần tử được duyệt
            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.ReadKey();

            /* việc truy xuất các phần tử trong hashtable gống 
             trong mảng vậy nhưng không thông qua chỉ số phần tử mảng mà
            là key
            ==> vd :Console.WriteLine(hash["K"]);

              ++ trong đó:
               > hash: là tên đại diện khởi tạo của Hashtable
               > "K": là tên key cần truy xuất
               --> hash["K"]: sẽ lấy value trị tương ứng với key "K" là Kteam.
             */
            Console.WriteLine("nhap key can tim: ");
            String key = Console.ReadLine();
        
            // kiêm rtra xem VT có tồn tại không
            if (hash.ContainsKey(key))
            {
                Console.WriteLine(" key: " + key + " ton tai trong hashtable");
                foreach (DictionaryEntry item in hash)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }

                // tiến hành nhập lại key
                Console.WriteLine("nhap key can tim: ");
                key = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("key {0} khong ton tai", key);
                // gán giá trị tương ứng cho key vừa nhập muốn thêm vào hash
                Console.WriteLine("nhap gia tri value tương ung cho key: " + key + " la: ");
                String value = Console.ReadLine();

                // tiến hành dùng Add thêm cặp key-value mới vào hash
                /* có thể gán trực tiếp như sau:
                   hash[key] = value;
                or
                 */
                hash.Add(key, value);

                // tiến hành xuất lại các item trong hashtable
                foreach (DictionaryEntry item in hash)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }

            }

            Console.ReadLine();

            //tiến hành trả về tức in lại các giá trị phàn tử value của hashtable



        }
    }

}
