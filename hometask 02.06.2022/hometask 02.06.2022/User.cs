using System;
using System.Collections.Generic;
using System.Text;

namespace hometask_02._06._2022
{
     internal class User
     {
        public string UserName;
        private string Password;

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password)== false && password.Length > 7 && password.Length < 25 && HasUpper(password) && HasDigit(password)) 
              this.Password = password;
        }

        public string GetPassword()
        {
            return this.Password;
        }

        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;

            }
            return false;
        }

        public bool HasDigit(string str)
        {
            for (int i =0; i< str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }
            return false;

        }
     }
}
