using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIBA
{
    class Cart1
    {
        protected string productname;
        protected string quantity;
        public Cart1(string productname)
        {
            this.productname = productname;

        }
        public Cart1(string productname, string quantity)
        {
            this.productname = productname;
            this.quantity = quantity;
        }
        public string getproductname()
        {
            return productname;
        }
        public void setprooductname(string productname)
        {
            this.productname = productname;
        }
        public string getquantity()
        {
            return quantity;
        }
        public void setquantity(string quantity)
        {
            this.quantity = quantity;
        }
    }
}
