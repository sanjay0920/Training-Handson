using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace categorylibrary
{
    public class Category
    {
            private int _catid;
            public int CatID
            {
                get { return _catid; }
                set { _catid = value; }
            }
            private string _catname;
            public string CatName
            {
                get { return _catname; }
                set { _catname = value; }
            }
            private string _desc;
            public string Description
            {
                get { return _desc; }
                set { _desc = value; }
            }
            private List<Products> _prodlist;
            public List<Products> ProductsList
            {
                get { return _prodlist; }
                set { _prodlist = value; }
            }

            static int Productcount;
            public void CountProduct()
            {
                Productcount = Productcount + 1;
                Console.WriteLine("You added total Nos of Products: " + Productcount);
            }
        }