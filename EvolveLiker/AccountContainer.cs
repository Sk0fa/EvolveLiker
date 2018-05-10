using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class AccountContainer
    {
        public int LoggedInAccounts => Accounts.Count(a => a.IsLoggedIn);
        public List<Account> Accounts { get; }

        public AccountContainer()
        {
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public void LoginInAccounts()
        {
            foreach(var acc in Accounts)
            {
                if (!acc.IsLoggedIn)
                    acc.TryLogin();
            }
        }

        public int PutLikes(string uri, string login, int count)
        {
            var putLikesCount = 0;
            var accs = Accounts.Where(a => a.IsFreeForPutLike).Take(count).ToArray();
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
