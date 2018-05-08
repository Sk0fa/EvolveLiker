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

        private readonly Connection connection;

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
            connection = new Connection();
            LastPutLike = DateTime.MinValue;
        }

        public bool TryLogin()
        {
            return connection.TryLogin(Login, Password);
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
