using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIBA.BL
{
    class ProductCategory
    {
        

        protected string category;
        public ProductCategory(string category)
        {
            this.category = category;
        }
        public string getCategory()
        {
            return category;
        }
        public void setCategory(string category)
        {
            this.category = category;
        }
    }
}
