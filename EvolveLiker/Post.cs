using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolveLiker
{
    public class Post
    {
        public string PostOwner { get; set; }
        public string HtmlText { get; set; }
        public string Uri { get; set; }

        public Post(string postOwner, string htmlText, string uri)
        {
            PostOwner = postOwner;
            HtmlText = htmlText;
            Uri = uri;
        }
    }
}
