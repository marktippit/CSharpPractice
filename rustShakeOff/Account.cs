using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rustShakeOff
{
    class Account
    {
        private string name = "Jane Doe"; // instance variable

        //method that sets the account name in the object
        public void SetName(string accountName)
        {
            name = accountName;//store the account name
        }

        //method that retrieves the account name from the object
        public string GetName()
        {
            return name;
        }
    }
}
