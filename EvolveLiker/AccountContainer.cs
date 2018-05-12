using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                    Thread.Sleep(2000);
            }
        }

        public int PutLikes(string uri, string login, int count)
        {
            var putLikesCount = 0;
            var accs = Accounts.Where(a => a.IsFreeForPutLike).Take(count).ToArray();
            var link = Finder.FindLikeLink(Finder.FindPost(Accounts[0].Connection, uri, login));
            for (var i = 0; i < count; i++)
            {
                var succes = accs[i].TryPutLike(link);
                if (succes)
                    putLikesCount++;
                Thread.Sleep(2000);
            }
            return putLikesCount;
        }
    }
}
