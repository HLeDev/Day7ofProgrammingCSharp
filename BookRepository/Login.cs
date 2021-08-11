using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRepository
{
    public class Login
    {

        Dictionary<string, string> LoginCredentials;
        //key value unique 1:1 (key, value), 1st string is key, 2nd string is value
        public Login()
        {
            LoginCredentials = new Dictionary<string, string>();
            LoginCredentials.Add("Admin", "Password"); //unique login, admin is key, password is value
        }

        public bool loggingin(string username, string password) //checking to see if entered correctly
        {
            string enteredPassword;
            if (LoginCredentials.TryGetValue(username, out enteredPassword)) //username is key, comparing value of password entered with key
            {
                if (enteredPassword == password) //entered password is stored in memory, password is the password entered
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }
    }
}
