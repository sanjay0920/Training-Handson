using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productlibrary
{
    public class product
    {
        int _productID;

        public int PRODUCTID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        string _productName;

        public string PRODUCTNAME
        {
            get { return _productName; }
            set { _productName = value; }
        }

        int _qntysold;
        public int QUANTITYSOLD
        {
            get { return _qntysold; }
            set { _qntysold = value; }
        }

        int _unitprice;
        public int UNITPRICE
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }

        string _uomes;
        public string UNITOFMEASUREMENT
        {
            get { return _uomes; }
            set { _uomes = value; }
        }

        int _qihand;
        public int QUANTITYINHAND
        {
            get { return _qihand; }
            set { _qihand = value; }
        }


    }
}
