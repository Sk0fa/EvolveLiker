using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolveLiker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = new Connection();
            var a = c.TryLogin("roflanTigran", "123123");
            textBox1.Text += a + "\r\n";
            var b = c.TryPutLike("http://evolve-rp.su/posting.php?mode=thx&f=11&p=1354046", new PostData().AddParam("thanks", ""));
            textBox1.Text += b + "\n";
        }
    }
}
