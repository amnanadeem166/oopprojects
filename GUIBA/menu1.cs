using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUIBA.DL;

namespace GUIBA
{
    public partial class menu1 : UserControl
    {
        int index;
        DataTable table = new DataTable("table");
        
        public menu1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string filePath = "menu.txt"; // Replace with your actual file path
            List<string> lines = ReadTextFile(filePath);
            LoadDataIntoDataGridView(lines);
        }

        private void LoadDataIntoDataGridView(List<string> lines)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Food name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Description", typeof(string));



            foreach (string line in lines)
            {
                string[] rowData = line.Split(',');
                table.Rows.Add(rowData);
            }

            dataGridView1.DataSource = table;
        }

        private List<string> ReadTextFile(string filePath)
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (line != "")
                    {
                        lines.Add(line);
                    }
                }
            }
            return lines;
        }


        private void dataBind()
        {

            try
            {
                table = new DataTable(); // Initialize the DataTable if necessary
                table.Columns.Add(" Food name", typeof(string));
                table.Columns.Add(" Food Category", typeof(string));
                // table.Columns.Add(" Food price", typeof(string));
                // table.Columns.Add(" Description", typeof(string));

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while setting up the data source: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ProductName = textBox2.Text;
                while (!ProductDL.isvalidproductname(ProductName))
                {
                    MessageBox.Show("Invalid name! Please enter a valid name:");
                    return;
                }

                string quantity = textBox1.Text;
                while (!ProductDL.IsValidprice(quantity))
                {
                    MessageBox.Show("Invalid quantity! Please enter a valid quantity:");
                    return; // Stop execution if the name is invalid
                }
                

                string productFilePath = "menu.txt";
                List<string> productLines = ReadTextFile(productFilePath);
                List<string> cartLines = new List<string>();
                
                foreach (string line in productLines)
                {
                    string[] data = line.Split(',');
                    if (data.Length > 0 && data[0] == ProductName)
                    {
                        Cart1 u = new Cart1(ProductName, quantity);
                        CartDL.storeDataInListcart(u);
                        CartDL.storeProductDataInFilecart(u);

                        MessageBox.Show("Stored in file");
                    }

                }

                if (ProductName != "" && quantity != "")
                {
                    LoadTableGrid2();
                }
                else
                {
                    MessageBox.Show("Invalid data! Please enter a valid data:");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding a new row: " + ex.Message);
            }

        }

        private void LoadTableGrid2()
        {
            string filePath = "cart.txt"; // Replace with your actual file path
            List<string> lines = ReadTextFile(filePath);

            // Call the LoadDataIntoDataGridView method to load data into the DataGridView
            LoadDataIntoDataGridView2(lines);
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            //    Form f = new ();
            //    f.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[index];
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
        }


        private void LoadDataIntoDataGridView2(List<string> lines)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Food name", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            foreach (string line in lines)
            {
                string[] rowData = line.Split(',');
                table.Rows.Add(rowData);
            }

            dataGridView2.DataSource = table;
        }


        private void dataBind2()
        {

            try
            {
                table = new DataTable(); // Initialize the DataTable if necessary
                table.Columns.Add(" Food name", typeof(string));
                table.Columns.Add(" Food Category", typeof(string));
                // table.Columns.Add(" Food price", typeof(string));
                // table.Columns.Add(" Description", typeof(string));

                dataGridView2.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while setting up the data source: " + ex.Message);
            }
        }

    }
}
