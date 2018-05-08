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
            var acc = new Account("macrochel", "123123");
            var a = acc.TryLogin();
            textBox1.Text += a + "\r\n";
            var b = acc.TryPutLike("http://evolve-rp.su/viewtopic.php?f=11&t=31746&start=2410", "owl.50");
            textBox1.Text += b + "\n";
        }
    }
}
