using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_Number_5_6
{

    public delegate string UserDelegate(string str);

    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int TotalMoneyInAccount { get; set; }
        public int Depositing { get; set; }

        public User(string username, string password, int deposit)
        {
            UserName = username;
            Password = password;
            Depositing = deposit;
            TotalMoneyInAccount += Depositing;
        }
    }

    class ClientsManagement
    {
        public static List<User> clients = new List<User>() { new User("Gilalk", "123gil", 150), new User("Avia2", "246avi", 200), new User("Zivzuv", "137zizi",320)};

        public static event UserDelegate SuccessLoginEvent;
        public static event UserDelegate UnSuccessLoginEvent;

        public static string Login(string username, string password)
        {
            foreach (var client in clients)
            {
                if(client.UserName == username && client.Password == password)
                {
                    SuccessLoginEvent = SuccessLogin;
                    return SuccessLoginEvent(client.UserName);
                }
            }
            UnSuccessLoginEvent = UnsuccessLogin;
            return UnSuccessLoginEvent(username);
        }
        
        public static string SuccessLogin(string name)
        {
            return $"Welcome {name}";
        }

        public static string UnsuccessLogin(string name)
        {
            return "Wrong Details";
        }
    }
}
