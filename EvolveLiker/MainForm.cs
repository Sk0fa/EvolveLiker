using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            var a = c.TryLogin("roflanBuldiga", "123123");
            var b = c.TryPutLike("http://evolve-rp.su/viewforum.php?f=11&sid=eb208ba26c97f7a6c53b5ee26a233071", "a");
        }
    }
}
