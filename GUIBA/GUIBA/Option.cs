using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIBA.signDL;

namespace GUIBA
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form newForm = new Signup();
            this.Hide();
            newForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form newForm = new Signin();
            this.Hide();
            newForm.Show();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            string path = "users.txt";
            if (MuserDL.readuserdatafromfile(path))
            {
                MessageBox.Show("Data loaded from the file");

            }
            else
            {
                MessageBox.Show("data loaded from file");
            }
        }
    }
}
