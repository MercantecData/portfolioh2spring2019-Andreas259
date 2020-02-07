using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Job Job { get; private set; }

        public bool isAdmin()
        {
            if (this is Admin)
            {
                return true;
            }

            return false;
        }
    }
}
