using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIBA.signBL;
using GUIBA.BL; 

namespace GUIBA.BL
{
    class Addtocart 
    {

      

        protected string productname;
        protected string quantity;
        public Addtocart(string productname)
        {
            this.productname = productname;

        }
        public Addtocart(string productname, string quantity)
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
