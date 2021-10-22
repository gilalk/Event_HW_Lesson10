using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_number_5
{

    public delegate void UserDelegate();

    public class User
    {
        public static string UserName { get; set; } = "Gilalk";
        public static string Password { get; set; } = "12345";
    }

    public class Login
    {
        public static event UserDelegate SuccessLoginEvent;
        public static event UserDelegate UnSuccessLoginEvent;

        public static void SuccessLogin()
        {
            Console.WriteLine("Welcome to the system!");
        }

        public static void UnSuccessLogin()
        {
            Console.WriteLine("Wrong username or password");
        }

        public static void LoginUser(string userName, string password)
        {
            if (userName == User.UserName && password == User.Password)
            {
                SuccessLoginEvent += SuccessLogin;
                SuccessLoginEvent();
                SuccessLoginEvent -= SuccessLogin;
            }
            else
            {
                UnSuccessLoginEvent += UnSuccessLogin;
                UnSuccessLoginEvent();
                UnSuccessLoginEvent -= UnSuccessLogin;
            }
        }
    }
}
