using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Registry
    {
        List<User> users = new List<User>();
        List<Admin> admins = new List<Admin>();

        public void AddNewUser(User user)
        {
            users.Add(user);
        }

        public bool Login(string login, string password)
        {
            foreach (var user in users)
            {
                if (user.isAdmin())
                {
                    foreach (var admin in admins)
                    {
                        if (admin.Login == login && admin.Password == password)
                        {
                            return true;
                        }
                    }
                } 
                else
                {
                    if (user.Login == login && user.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
