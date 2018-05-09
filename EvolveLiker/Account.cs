using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class Account
    {       
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime LastPutLike { get; private set; }
        public bool IsFreeForPutLike => DateTime.Now.Subtract(LastPutLike).Hours >= 2;
        public bool IsLoggedIn { get; private set; }

        private readonly Connection connection;

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
            IsLoggedIn = false;
            connection = new Connection();
            LastPutLike = DateTime.MinValue;
        }

        public bool TryLogin()
        {
            IsLoggedIn = connection.TryLogin(Login, Password);
            return IsLoggedIn;
        }

        public bool TryPutLike(string uri, string login)
        {
            var post = Finder.FindPost(connection, uri, login);
            var link = Finder.FindLikeLink(post);
            var likePuts = connection.TryPutLike(link, new PostData().AddParam("thanks", ""));
            LastPutLike = likePuts ? DateTime.Now : LastPutLike;
            return likePuts;
        }
    }
}
