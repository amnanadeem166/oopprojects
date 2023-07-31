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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            table.Columns.Add("food name", typeof(string));
            table.Columns.Add("category", typeof(string));
            table.Columns.Add("price", typeof(string));
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
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
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
                table.Columns.Add(" Food price", typeof(string));
                table.Columns.Add(" Description", typeof(string));

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while setting up the data source: " + ex.Message);
            }
        }     
    }
}
