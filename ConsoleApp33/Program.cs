using System;
using ConsoleApp33.Interfaces;

namespace ConsoleApp33
{
    class Program
    {
        private static object password;

        static void Main(string[] args)
        {
            Console.WriteLine("Password Daxil edin");
            
            string password = Console.ReadLine();
            string email = "Hajimat";
            User user = new User(email, password);
           
            
            user.FullName = "Hajimat Alisultanov";
            user.ShowInfo();


            
        }
    }
}
