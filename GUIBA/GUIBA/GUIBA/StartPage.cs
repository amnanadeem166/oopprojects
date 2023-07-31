using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIBA
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        //    Form newForm = new login();
        //    newForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form newForm = new Option();
            this.Hide();
            newForm.Show();
        }
    }
}
