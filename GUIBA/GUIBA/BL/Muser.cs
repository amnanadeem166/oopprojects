using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIBA.signBL
{
    class Muser
    {
        private string username;
        private string password;
        private string role;

        public Muser (string username , string password ,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public Muser(string username , string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getusername()
        {
            return username;
        }

        public void setusername(string username)
        {
            this.username = username;
        }

        public string getpassword()
        {
            return password;
        }

        public void setpassword(string password)
        {
            this.password = password;
        }

        public string getrole()
        {
            return role;
        }

        public void setrole(string role)
        {
            this.role = role;
        }

        public bool isAdmin()
        {
            if (role == "admin")
            {
                return true;
            }
            return false;
        }

    }
}
