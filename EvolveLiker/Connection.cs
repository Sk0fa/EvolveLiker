using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace EvolveLiker
{
    public class Connection
    {
        public CookieContainer CookieContainer { get; set; }
        public WebClient WebClient { get; set; }

        private readonly string loginUri = "http://evolve-rp.su/ucp.php?mode=login";

        public Connection()
        {
            WebClient = new WebClient();
            CookieContainer = new CookieContainer();
            SetStartHeader();
            WebClient.Encoding = Encoding.UTF8;
        }

        public bool TryLogin(string login, string password)
        {
            var response = Web.GetString(this, loginUri);
            var sid = FindSid(response);
            response = Web.PostString(this, loginUri, GeneratePostData(login, password, sid));
            return CheckOnLogin(response);
        }

        public bool TryPutLike(string uri, string login)
        {
            var response = Web.GetString(this, uri);
            return false;
        }

        private static PostData GeneratePostData(string login, string password, string sid)
        {
            return new PostData()
                .AddParam("username", login)
                .AddParam("password", password)
                .AddParam("code", "")
                .AddParam("autologin", "on")
                .AddParam("sid", sid)
                .AddParam("redirect", "index.php")
                .AddParam("login", "Вход")
                .AddParam("redirect", "./ucp.php?mode=login");
        }

        private static bool CheckOnLogin(string response)
        {
            return response.Contains("Выход");
        }

        private void SetStartHeader()
        {
            WebClient.Headers[HttpRequestHeader.Cookie] =
                "beget = begetok; phpbb3_514hu_u = 1; phpbb3_514hu_k =; phpbb3_514hu_sid = 1";
            WebClient.Headers.Add("User-Agent", Web.UserAgent);
        }

        private static string FindSid(string content)
        {
            var rgx = new Regex(@"sid""\s+value=""(.*?)""", RegexOptions.Multiline);
            var matches = rgx.Matches(content);

            return matches.Count > 0 ? matches[0].Groups[1].Value : string.Empty;
        }
    }
}