using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using GUIBA.DL;

namespace GUIBA
{
    public partial class Customerfood : Form
    {
      
        public Customerfood()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataBind()
        {

          
          //  dataGridView1.Rows.Clear();
          //  dataGridView1.DataSource = null;
         //   for(int x  = 0; x < ProductDL.menu.Count; x++)
         //   {
         //       dataGridView1.Rows.Add(x.product);
         //   }
         //   dataGridView1.Refresh();
        }
        private void LoadDataIntoDataGridView(List<string> lines)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu11.BringToFront();
            ///////////////////
        }

        private void Customerfood_Load(object sender, EventArgs e)
        {

        }

        private void menu11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu21.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu31.BringToFront()
;        }
    }
}
