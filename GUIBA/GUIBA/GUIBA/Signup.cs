using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIBA.signBL;
using GUIBA.signDL;

namespace GUIBA
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            // string path = "users.txt";
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = textBox3.Text.ToLower();

            while (!MuserDL.isvalidname(username))
            {
                MessageBox.Show("Invalid name! Please enter a valid name:");
                return; // Stop execution if the name is invalid
            }


            if (!IsNumeric(password))
            {
                MessageBox.Show("Invalid password! Please enter a password consisting only of numeral digits.");
                return; // Stop execution if the password is invalid
            }


            if (role.ToLower() != "admin" && role.ToLower() != "customer")
            {
                MessageBox.Show("Invalid role! Please enter either 'admin' or 'customer'.");
                return; // Stop execution if the role is invalid
            }

            string path = "users.txt";
            Muser user = new Muser(username, password, role);
            MuserDL.adduserintoList(user);
            MuserDL.AddusersdatatoFile(path);

            MessageBox.Show("Stored in file");

            Muser validUser = MuserDL.signIn(user);
            if (validUser != null)
            {
                MessageBox.Show("User is valid");
                if(role == "admin")
                {
                    Form admin = new Admintrial();
                    this.Hide();
                    admin.Show();
                }
                else if(role == "customer")
                {
                    Form customer = new Customerfood();
                    this.Hide();
                    customer.Show();
                }
            }
            else
            {
                MessageBox.Show("User is invalid");
            }
            //////////////////////////////////////////////////////////////////////////////////////////////
            //Muser sign = new Muser(username , password , role);
            //MuserDL.adduserintoList(sign);
            //MuserDL.AddusersdatatoFile(path);

            //if(role =="admin")
            //{
            //    Form newform = new Admintrial();
            //    newform.Show();
            //}
            //if (role == "customer")
            //{
            //    Form newform = new Customerdetails();
            //    newform.Show();

            //}        

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
