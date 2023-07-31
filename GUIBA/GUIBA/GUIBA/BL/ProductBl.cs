using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIBA.BL;

namespace GUIBA.signBL
{
    class ProductBl :  ProductCategory        
    {
        protected string productname;  
        protected string productprice;
        protected string productquantity;
        protected string path;
       // protected string productname1;
        protected string description;
        public ProductBl(string category) :base (category)
        {
            this.category = category;
        }
    
        public ProductBl(string productname ,string productprice , string productquantity  , string category ,string description): base(category)
        {
            this.productname = productname;
            this.productquantity = productquantity;
            this.productprice = productprice;
            this.category = category;
            this.description = description;

        }

        public ProductBl(string productname, string category , string productprice ,string description):base(category)
        {
            this.productname = productname;
            this.category = category;
            this.productprice = productprice;
            this.description = description;
           

        }

        public string getproductname()
        {
            return productname;
        }

        public string getproductprice()
        {
            return productprice;
        }

        public string getproductquantity()
        {
            return productquantity;
        }

        public string getcategory()
        {
            return category;
        }
        public string getdescription()
        {
            return description;
        }

        public void setproductname(string productname)
        {
            this.productname = productname;
        }

        public void setproductprice(string productprice)
        {
            this.productprice = productprice;
        }
        public void setproductquantity(string productquantity)
        {
            this.productquantity = productquantity;
        }
        public void setcategory(string category)
        {
            this.category = category;
        }

        public void setdescription(string description)
        {
            this.description = description;
        }











    }
}
