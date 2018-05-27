using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class Account
    {       
        public string Login { get; private set; }
        public string Password { get; set; }
        public DateTime LastPutLike { get; private set; }
        public bool IsFreeForPutLike => DateTime.Now.Subtract(LastPutLike).Hours >= 2;
        public bool IsLoggedIn { get; private set; }
        public Connection Connection { get; private set; }

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
            IsLoggedIn = false;
            Connection = new Connection();
            LastPutLike = DateTime.MinValue;
        }

        public bool TryLogin()
        {
            IsLoggedIn = Connection.TryLogin(Login, Password);
            return IsLoggedIn;
        }

        public bool TryPutLike(string link)
        {
            var likePuts = Connection.TryPutLike(link, new PostData().AddParam("thanks", ""));
            LastPutLike = likePuts ? DateTime.Now : LastPutLike;
            return likePuts;
        }
    }
}
