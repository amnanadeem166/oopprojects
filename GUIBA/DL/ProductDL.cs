using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIBA.signBL;
using GUIBA.BL;
using System.IO;

namespace GUIBA.DL
{
    class ProductDL 
    {

        string path = "menu.txt";
        public static List<ProductBl> menu = new List<ProductBl>();
       

        public static void Addfoodtolist(ProductBl food)
        {
            menu.Add(food);
        }

        public static void AddProductsdatatoFile()
        {
            string path1 = "menu.txt";
            StreamWriter file = new StreamWriter(path1, false);

            for (int x = 0; x < menu.Count; x++)
            {
                file.WriteLine(menu[x].getproductname() + "," + menu[x].getcategory() + "," + menu[x].getproductprice() + "," + menu[x].getdescription());
           }
            file.Flush();
            file.Close();
        }

        public static bool readuserdatafromfile()
        {
            string path1 = "menu.txt";
            StreamReader file = new StreamReader(path1);

            if (File.Exists(path1))
            {
                string record;
                while ((record = file.ReadLine()) != null)
                {

                    string productname = parseRecord(record, 1);
                    string category = parseRecord(record, 2);
                    string productprice = parseRecord(record, 3);
                    string description = parseRecord(record, 4);

                    ProductBl food = new ProductBl(productname, category, productprice, description);

                    Addfoodtolist(food);
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static string parseRecord(string line, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    item = item + line[i];
                }
            }
            return item;
        }

        public static bool IsValidprice(string productprice)
        {
            bool isValid = true;
            int size =productprice.Length;

            for (int i = 0; i < size; i++)
            {
                if (!char.IsDigit(productprice[i]))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public static bool isvalidproductname(string productname)
        {
            bool flag = true;
            int size = productname.Length;
            for (int i = 0; i < size; i++)
            {
                if ((productname[i] >= 95 && productname[i] <= 120))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }

            }
            return flag;
        }
        public static void deleteproduct(string productname)
        {
            Console.Clear();
            string path = "menu.txt";
            List<string> lines = File.ReadAllLines(path).ToList();
            bool productFound = false;
            for (int i = 0; i < lines.Count; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields[0] == productname)
                {
                    lines.RemoveAt(i);
                    productFound = true;
                    break;
                }
            }
            if (productFound)
            {
                File.WriteAllLines(path, lines);
                Console.WriteLine($"Product '{productname}' deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Product '{productname}' not found.");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("if you want to go main menu press any key");
            Console.ReadLine();


        }


    }
}
