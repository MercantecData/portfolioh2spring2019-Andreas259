using System;
using UserLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Registry registry1 = new Registry();
            registry1.AddNewUser(new User("andreas", "abcd1234", new HourlyPaidJob(172)));
            registry1.Login("andreas", "abcd1234");
        }
    }
}
