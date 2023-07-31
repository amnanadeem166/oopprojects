using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIBA.DL;
using GUIBA.signBL;

namespace GUIBA
{
    public partial class Add_Drink : Form
    {
        int index;
        DataTable table = new DataTable("table");
        public Add_Drink()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void AddDrink(object sender, EventArgs e)
        {
            try
            {
                table = new DataTable(); // Initialize the DataTable if necessary
                table.Columns.Add(" Drink name", typeof(string));
                table.Columns.Add(" Drink Category", typeof(string));
                table.Columns.Add(" Drink price", typeof(string));
                table.Columns.Add(" Description", typeof(string));

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while setting up the data source: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                string productname = textBox1.Text;
                while (!ProductDL.isvalidproductname(productname))
                {
                    MessageBox.Show("Invalid productname! Please enter a valid name:");
                    return; // Stop execution if the name is invalid
                }
                string category = textBox2.Text;
                while (!ProductDL.isvalidproductname(category))
                {
                    MessageBox.Show("Invalid Category! Please enter a valid category:");
                    return; // Stop execution if the name is invalid
                }

                string productprice = textBox3.Text;
                while (!ProductDL.IsValidprice(productprice))
                {
                    MessageBox.Show("Invalid price please enter valid price:");
                    return; // Stop execution if the name is invalid
                }

                string description = textBox4.Text;
                while (!ProductDL.IsValidprice(productprice))
                {
                    MessageBox.Show("Invalid price please enter valid price:");
                    return; // Stop execution if the name is invalid
                }




                string path = "drink.txt";
                ProductBl food = new ProductBl(productname, category, productprice, description);
                ProductDL.Addfoodtolist(food);
                ProductDL.AddProductsdatatoFile();

                MessageBox.Show("Stored in file");

                // Make sure 'table' is properly initialized and accessible
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while adding a new row: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    index = dataGridView1.CurrentCell.RowIndex;
                    if (index >= 0 && index < dataGridView1.Rows.Count)
                    {
                        string productName = dataGridView1.Rows[index].Cells[0].Value.ToString();

                        // Delete the corresponding data from the file
                        ProductDL.deleteproduct(productName);
                        // Remove the row from the DataGridView
                        dataGridView1.Rows.RemoveAt(index);

                        // Get the product name from the deleted row

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while removing the row: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
