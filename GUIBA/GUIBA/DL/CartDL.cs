using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GUIBA.DL
{
    class CartDL
    {
        protected string path = "cart.txt";
        public static List<Cart1> user = new List<Cart1>();
        public static void storeDataInListcart(Cart1 temp)
        {
            user.Add(temp);
        }
        /// <summary>
        /// store in file in cart
        /// </summary>
        /// <param name="temp"></param>
        public static void storeProductDataInFilecart(Cart1 temp)
        {
            string path = "cart.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(temp.getproductname() + "," + temp.getquantity());

            file.Flush();
            file.Close();

        }
    }
}
