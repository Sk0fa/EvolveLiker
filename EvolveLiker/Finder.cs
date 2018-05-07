using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace EvolveLiker
{
    public static class Finder
    {
        public static Post FindPost(string uri, string login)
        {
            var response = Web.GetString(new Connection(), "http://evolve-rp.su/viewtopic.php?f=11&t=31746&start=2430");
            var doc = new HtmlDocument();
            doc.LoadHtml(response);
            var node = doc.DocumentNode.SelectSingleNode(".//table[@class=\'tablebg\' and node()[contains(., \'Автор\')]]");
            return new Post(login, node.InnerHtml, uri);
        }
    }
}
