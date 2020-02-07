using System;
using System.Collections.Generic;
using System.Text;

namespace UserLibrary
{
    public class User
    {
        public string Login { get; private set; }
        string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (IsAdmin())
                {
                    password = value;
                }
            }
        }
        public Job Job { get; private set; }

        public User(string login, string password, Job job)
        {
            Login = login;
            this.password = password;
            Job = job;
        }

        public bool IsAdmin()
        {
            if (this is Admin)
            {
                return true;
            }

            return false;
        }
    }
}