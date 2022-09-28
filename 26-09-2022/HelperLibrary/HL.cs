using BusinessLogicLayerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerLibrary;

namespace HelperLibrary
{
    public class HL
    {
        public void Addbook(BLL_LIB Book)
        {
            DAL Library = new DAL();
            Library.InsertBook(Book);

        }

        public void UpdateBook(BLL_LIB Book)
        {
            DAL Library = new DAL();
            Library.UpdateBook(Book);

        }

        public void Login(Users User)
        {
            DAL Library = new DAL();
            List<BLL_LIB> BookL = Library.booklist(User);

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (BLL_LIB LibraryL in BookL)
            {
                Console.WriteLine("Book_No: " + LibraryL.Book_No);
                Console.WriteLine("Book_Name: " + LibraryL.Book_Name);
                Console.WriteLine("Book Author: " + LibraryL.Author);
                Console.WriteLine("Book_Price: " + LibraryL.Cost);
                Console.WriteLine("Book_Category: " + LibraryL.Category);
                Console.WriteLine();
            }
            Console.WriteLine("Do you want to Borrow Books (Y/N)? ");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
            {
                Library.BorrowBooks();
                Console.WriteLine("Book issued Now");
            }

        }

        public void ReturnBooks()
        {
            DAL Library = new DAL();
            Library.returnbook();
            Console.WriteLine("Book returned Sucessfully");

        }

    }
}
