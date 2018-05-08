using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EvolveLiker
{
    [TestFixture]
    public class Tests
    {
        private readonly string testUri = "http://evolve-rp.su/viewtopic.php?f=11&t=31746&start=2420";
        private readonly string testNick = "Gabriello_Galante";
        private readonly Connection conn = new Connection();

        [Test]
        public void TestGetPost()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(conn.TryLogin("roflanDovolen", "123123"));
            var post = Finder.FindPost(conn, testUri, testNick);
            Assert.True(post.HtmlText.Contains("name=\"thanks\""));
        }

        [Test]
        public void TestGetLikeLink()
        {
            Assert.IsTrue(conn.TryLogin("roflanBuldiga", "123123"));
            var link = Finder.FindLikeLink(Finder.FindPost(conn, testUri, testNick));
            Assert.AreEqual("http://evolve-rp.su/posting.php?mode=thx&f=11&p=1350428", link);
        }
    }
}
