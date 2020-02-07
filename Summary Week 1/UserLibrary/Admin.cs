using System;
using System.Collections.Generic;
using System.Text;

namespace UserLibrary
{
    class Admin : User
    {
        public Admin(string login, string password, Job job) : base(login, password, job)
        {
        }

        public void ChangePassword(User user, string newPassword)
        {
            user.Password = newPassword;
            Console.WriteLine("Password for user {0} has been changed", user.Login);
        }
    }
}
