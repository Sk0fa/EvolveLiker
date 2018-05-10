using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolveLiker
{
    public partial class MainForm : Form
    {
        private readonly MainWorker mainWorker;

        public MainForm()
        {
            InitializeComponent();
            mainWorker = new MainWorker();
        }

        private void btnAddAccs_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                if (ofd.FileName != null)
                {
                    var accsCount = mainWorker.LoadAccounts(ofd.FileName);
                    lblAccountsCount.Text = accsCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void btnLoginAccs_Click(object sender, EventArgs e)
        {
            var loginAccsCount = mainWorker.LoginInAccs();
            lblAccountsLoggedIn.Text = loginAccsCount.ToString();
        }
    }
}
