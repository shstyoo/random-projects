using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thePlayground
{
    class userAcct
    {
        // Default Constructor
        // All fields are empty values
        public userAcct()
        {
            username =  "";
            password =  "";
            birthDate = "";
            secretQ =   "";
            secretA =   "";
        }

        // This funciton will write the current username & info to database
        public void writeToDatabase()
        {
            // Write code here
        }

        // Private variables for user accounts (with getters & setters)

        // Get/Set username
        public string username { get; set; }

        // Get/Set password
        public string password { get; set; }

        // Get/Set user birthday
        public string birthDate { get; set; }

        // Get/Set users secret question (for account recovery)
        public string secretQ { get; set; }

        // Get/Set users answer to secret question
        public string secretA { get; set; }
    }
}
