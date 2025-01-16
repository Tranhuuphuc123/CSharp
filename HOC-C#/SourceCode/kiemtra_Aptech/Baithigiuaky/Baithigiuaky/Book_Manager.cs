using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* bài thi giữa kỳ*/

namespace Baithigiuaky
{
    class Book
    {
        private string author;
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
            }
        }

        private int pages;
       
        private string isbn;
        public string ISBN
        {
            get { return isbn; }
           
        }

        private string title;
        private int current_page;

        // contructor
        public Book() {
            current_page = 1;
        }

        public Book(string author, int pages, string isbn ,string title, int current_page =1)
        {
            this.Author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.current_page = current_page;     
        }


        // method flipPageForward
        public void FlipPageForward()
        {
            if (current_page < pages )
            {
                current_page++;
                Console.WriteLine("trang ke tiep: " + current_page);
            }
          
            
        }

        // method flipPagebackward
        public void FlipPageBackward()
        {
            if(current_page > 1)
            {
                current_page--;
                Console.WriteLine("trang o sau: " + current_page);
            }

          
        }

        // mehtod nhap
        public void Input()
        {
            Console.WriteLine("Enter ten Author: ");
            Author = Console.ReadLine();
            Console.WriteLine("nhap tong so Pages: ");
            pages = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ma ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("nhap ten ten Tile: ");
            title = Console.ReadLine();
            Console.WriteLine("nhap trang hien tai curentPages: ");
            current_page = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Author of Book: " + Author);
            Console.WriteLine("pages of Book: " + pages);
            Console.WriteLine("ISBN of Book: " + ISBN);
            Console.WriteLine("Tittle of books: " + title);
            Console.WriteLine("Current_Pages of Books: " + current_page);
        }

    }



    // class thực thi chương trình có hàm main
     class Demo { 
       static void Main(String[] args)
        {
            Book book = new Book();
            book.Input();
            Console.WriteLine("-----------xaut gia tri------------");    
            book.Display();

            
            book.FlipPageForward();
            book.FlipPageBackward();

            Console.ReadKey();
        }
    }
    
}
