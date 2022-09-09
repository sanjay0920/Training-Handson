using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ClassLibrary1
{
    public class Book
    {
        private int Bookid;
        public int ID
        {
            get { return Bookid; }
            set { Bookid = value; }
        }
        private string Bookname;
        public string Name
        {
            get { return Bookname; }
            set { Bookname = value; }
        }
        private int Price;
        public int price
        {
            get { return Price; }
            set { price = value; }

        }
        private string Author;
        public string name
        {
            get { return Author; }
            set { Author = value; }
        }
        private int categoryid;
        public int iD

        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        private string categoryname;
        public string NAME
        {
            get { return categoryname; }
            set { categoryname = value; }
        }
        private string description;
        public string Desc
        {
            get { return description; }
            set { description = value; }

        }
        private int _customerid;

        public int CustomerId
        {
            get { return _customerid; }
            set { _customerid = value; }
        }

    }
    

    public void InsertData(int Bookid, string Bookname, int Price)
        {
            this.ID = Bookid;
            this.Name = Bookname;
            this.price = Price;

        }
        class Novel : Book
        {
            public new void InsertData(int Bookid, string Bookname, int Price)
            {
                this.ID = Bookid;
                this.Name = Bookname;
                this.price = Price;

            }
        }
    }
}