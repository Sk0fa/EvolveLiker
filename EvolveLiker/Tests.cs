using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EvolveLiker
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestGetPost()
        {
            var post = Finder.FindPost("http://evolve-rp.su/viewtopic.php?f=11&t=31746&start=2430", "1");
            Assert.True(post.HtmlText.Contains("yo"));
        }
    }
}
