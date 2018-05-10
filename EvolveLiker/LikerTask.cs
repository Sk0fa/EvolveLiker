using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class LikerTask
    {
        public string TargetLogin { get; }
        public Dictionary<string, bool> UriList { get; }
        public bool IsComplete => LikesCountComplete == LikesCount;
        public int LikesCount { get; }
        private int LikesCountComplete;
        private AccountContainer accountContainer;
        private bool IsStop;

        public LikerTask(string targetLogin, int likesCount,
            AccountContainer accountContainer)
        {
            LikesCount = likesCount;
            TargetLogin = targetLogin;
            UriList = new Dictionary<string, bool>();
            this.accountContainer = accountContainer;
            IsStop = false;
        }

        public void AddUri(string uri)
        {
            UriList.Add(uri, false);
        }

        public void Start()
        {
            IsStop = false;
            while (!IsStop && !IsComplete)
            {
                var uri = UriList.Where((k, v) => !k.Value).FirstOrDefault().Key;
                UriList[uri] = true;
                var likesComplete = accountContainer.PutLikes(uri, TargetLogin, LikesCount - LikesCountComplete);
                LikesCountComplete += likesComplete;
                Task.Delay(1000 * 60 * 60 * 2, new CancellationToken(IsStop));
            }
        }

        public void Stop()
        {
            IsStop = true;
        }
    }
}