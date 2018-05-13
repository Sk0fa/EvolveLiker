using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace EvolveLiker
{
    public static class Finder
    {
        public static Post FindPost(Connection connection, string uri, string login)
        {
            var response = Web.GetString(connection, uri);
            var doc = new HtmlDocument();
            doc.LoadHtml(response);
            var node = doc.DocumentNode.SelectSingleNode(
                $"/html/body[@class=\'ltr\']/div[@id=\'wrap\']/div[@id=\'wrapcentre\']/div[@id=\'pagecontent\']/table[@class=\'tablebg\' and contains(.//tr/td/b, \'{login}\')]");
            var a = node.InnerHtml;
            return new Post(login, node.InnerHtml, uri);
        }

        public static string FindLikeLink(Post post)
        {
            var rgx = new Regex(@"action=""(.*?)"".*?name=""thanks""");
            var matches = rgx.Matches(post.HtmlText);
            return matches.Count > 0
                ? $"http://evolve-rp.su{matches[0].Groups[1].Value.Substring(1).Replace("amp;", "")}"
                : "";
        }
    }
}