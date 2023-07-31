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
using GUIBA.signBL;

namespace GUIBA
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
           
            while (!MuserDL.isvalidname(username))
            {
                MessageBox.Show("Invalid name! Please enter a valid name:");
                return;
            }
            if (!IsNumeric(password))
            {
                MessageBox.Show("Invalid password! Please enter a password consisting only of numeral digits.");
                return;
            }

            Muser user = new Muser(username, password);
            string path = "users.txt";
            bool check = MuserDL.readuserdatafromfile(path);
            if (check == true)
            {
                Muser validUser = MuserDL.signIn(user);
                if (validUser != null)
                {
                    
                    if ((validUser.isAdmin()))
                    {
                        Form moreform = new Admintrial();
                        moreform.Show();
                    }
                    else
                    {
                        Form moreform = new Customerdetails();
                        moreform.Show();

                        
                    }
                }
                else
                {
                    MessageBox.Show("user already exits");

                }


                Console.ReadLine();

            }
            else
            {
                MessageBox.Show("user is ......................invalid");

            }
        }
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
