using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class MainWorker
    {
        public AccountContainer AccountContainer { get; }

        public MainWorker()
        {
            AccountContainer = new AccountContainer();
        }

        public int LoadAccounts(string filename)
        {
            var accsLines = File.ReadAllLines(filename);
            foreach (var acc in accsLines)
            {
                AccountContainer.AddAccount(new Account(acc.Split(':')[0], acc.Split(':')[1]));
            }

            return AccountContainer.Accounts.Count;
        }

        public int LoginInAccs()
        {
            AccountContainer.LoginInAccounts();
            return AccountContainer.LoggedInAccounts;
        }
    }
}
