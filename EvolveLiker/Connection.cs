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

        public bool TryPutLike(string uri, PostData postData)
        {
            //GenerateHeadersForPutLike();
            return CheckOnPutLike(Web.PostString(this, uri, postData));
        }

        private void GenerateHeadersForPutLike()
        {
            WebClient.Headers.Add("Origin", "http://evolve-rp.su");
            WebClient.Headers.Add(HttpRequestHeader.Referer, "http://evolve-rp.su/viewtopic.php?f=11&t=31746&start=2430");
            WebClient.Headers.Add("Upgrade-Insecure-Requests", "1");
            WebClient.Headers.Add(HttpRequestHeader.UserAgent, Web.UserAgent);
            WebClient.Headers.Add(HttpRequestHeader.Accept, "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
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

        private static bool CheckOnPutLike(string response)
        {
            return response.Contains("Вы успешно отблагодарили");
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