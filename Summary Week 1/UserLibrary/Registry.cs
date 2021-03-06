﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserLibrary
{
    public class Registry
    {
        List<User> users = new List<User>();
        List<Admin> admins = new List<Admin>();

        public void AddNewUser(User user)
        {
            if (user.IsAdmin())
            {
                admins.Add(user as Admin);
            }
            else
            {
                users.Add(user);
            }
            Console.WriteLine("User {0} has been created", user.Login);
        }

        public bool Login(string login, string password)
        {
            foreach (var user in users)
            {
                if (user.IsAdmin())
                {
                    foreach (var admin in admins)
                    {
                        if (admin.Login == login && admin.Password == password)
                        {
                            Console.WriteLine("User {0} has been signed in", admin.Login);
                            return true;
                        }
                    }
                }
                else
                {
                    if (user.Login == login && user.Password == password)
                    {
                        Console.WriteLine("User {0} has been signed in", user.Login);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}