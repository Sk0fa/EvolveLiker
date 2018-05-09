using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class AccountContainer
    {
        public int LoggedInAccounts => accounts.Where(a => a.IsLoggedIn).Count();

        private List<Account> accounts;

        public AccountContainer()
        {
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public void LoginInAccounts()
        {
            foreach(var acc in accounts)
            {
                if (!acc.IsLoggedIn)
                    acc.TryLogin();
            }
        }

        public int PutLikes(string uri, string login, int count)
        {
            var putLikesCount = 0;
            var accs = accounts.Where(a => a.IsFreeForPutLike).Take(count).ToArray();
            for (var i = 0; i < count; i++)
            {
                var succes = accs[i].TryPutLike(uri, login);
                if (succes)
                    putLikesCount++;
            }
            return putLikesCount;
        }
    }
}
