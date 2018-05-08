using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public static class Web
    {
        public static string UserAgent =
            @"Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 66.0.3359.139 Safari / 537.36";

        public static string GetString(Connection connection, string uri)
        {
            var response = connection.WebClient.DownloadString(uri);
            return response;
        }

        public static string PostString(Connection connection, string uri, PostData postData)
        {
            var oldContentType = connection.WebClient.Headers[HttpRequestHeader.ContentType];
            connection.WebClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            var a = connection.WebClient.Headers[HttpRequestHeader.Cookie];
            var result = connection.WebClient.UploadString(uri, postData.GetParams());
            connection.WebClient.Headers[HttpRequestHeader.ContentType] = oldContentType;
            return result;
        }

        // TODO: Need REFACTOR!!!!
        public static void UpdateCoockie(Connection connection, string uri)
        {
            var rgx = new Regex(@"Set-Cookie:(.*?)\n");
            var matches = rgx.Matches(connection.WebClient.ResponseHeaders.ToString());
            var headerCookies = "";
            if (matches.Count > 0)
                headerCookies = matches[0].Groups[1].ToString();
            rgx = new Regex(
                @"[\s,]*(.*?)=(.*?); expires=.*?, \d+-.*?-\d+ \d+:\d+:\d+ .*?; path=.*?; domain=.*?; HttpOnly",
                RegexOptions.Multiline);
            matches = rgx.Matches(headerCookies);
            for (var i = 0; i < matches.Count; i++)
            {
                connection.CookieContainer.Add(new Uri(uri),
                    new Cookie($"{matches[i].Groups[1]}", $"{matches[i].Groups[2]}"));
            }
            connection.CookieContainer.Add(new Uri(uri), new Cookie("beget", "begetok"));
            var a = connection.CookieContainer.GetCookieHeader(new Uri(uri));
            connection.WebClient.Headers[HttpRequestHeader.Cookie] =
                connection.CookieContainer.GetCookieHeader(new Uri(uri));
        }
    }
}