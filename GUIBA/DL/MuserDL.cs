using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUIBA.signBL;
using System.IO;

namespace GUIBA.signDL
{
    class MuserDL
    {
        private static List<Muser> usersList = new List<Muser>();

        public static void adduserintoList(Muser user)
        {
            if (!Checkname(user))
            {
                usersList.Add(user);
            }
        }

        public static bool Checkname(Muser user)
        {
            for (int x = 0; x < usersList.Count; x++)
            {
                if (usersList[x].getusername() == user.getusername())
                {
                    return true;
                }
            }

            return false;
        }

        public static int Usersvalidation(Muser userinfovalidation)
        {
            for (int x = 0; x < usersList.Count; x++)
            {
                if (usersList[x].getusername() == userinfovalidation.getusername() && usersList[x].getpassword() == userinfovalidation.getpassword())
                {
                    if (usersList[x].getrole() == "admin" || usersList[x].getrole() == "Admin")
                    {
                        return 1;
                    }
                    if (usersList[x].getrole() == "user")
                    {
                        return 2;
                    }
                }
            }

            return 0;
        }
        public static Muser signIn(Muser u)
        {
            foreach (Muser storedUser in usersList)
            {
                if (u.getusername() == storedUser.getusername() && u.getpassword() == storedUser.getpassword())
                {
                    return storedUser;
                }
            }
            return null;
        }
        public static void AddusersdatatoFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);

            for (int x = 0; x < usersList.Count; x++)
            {
                file.WriteLine(usersList[x].getusername() + "," + usersList[x].getpassword() + "," + usersList[x].getrole());
            }
            file.Flush();
            file.Close();
        }

        public static bool readuserdatafromfile(string path)
        {
            StreamReader file = new StreamReader(path);

            if (File.Exists(path))
            {
                string record;

                while (!file.EndOfStream)
                {
                    record = file.ReadLine();
                    
                    if (record != "")
                    {
                        string[] data = record.Split(',');

                        string username = data[0];
                        string password = data[1];
                        string role = data[2];

                        Muser user = new Muser(username, password, role);
                        adduserintoList(user);
                    }
                }
                file.Close();
                return true;
            }
            else
                return false;
        }

        public static bool IsValidPassword(string password)
        {
            bool isValid = true;
            int size = password.Length;

            for (int i = 0; i < size; i++)
            {
                if (!char.IsDigit(password[i]))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public static bool isvalidname(string name)
        {
            bool flag = true;
            int size = name.Length;
            for (int i = 0; i < size; i++)
            {
                if ((name[i] >= 95 && name[i] <= 120))//||(name[i]<=122||name[i]==32))
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


    }



    }

