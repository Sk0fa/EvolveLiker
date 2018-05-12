using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class MainWorker
    {
        public AccountContainer AccountContainer { get; }
        public LikerTask CurrentTask { get; private set; }
        public BackgroundWorker worker { get; set; }

        public MainWorker()
        {
            AccountContainer = new AccountContainer();
        }

        public void SetLikerTask(LikerTask likerTask)
        {
            CurrentTask = likerTask;
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

        public void Start(BackgroundWorker worker)
        {
            this.worker = worker;
            CurrentTask.Start();
        }

        public void Stop()
        {
            CurrentTask.Stop();
        }

        public void LikerProgress(int count)
        {
            worker.ReportProgress(count / CurrentTask.LikesCount, count);
        }
    }
}