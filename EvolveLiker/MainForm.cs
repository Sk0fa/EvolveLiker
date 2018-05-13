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
        // JUST FOR TEST
        // aa
        private readonly MainWorker mainWorker;

        public MainForm()
        {
            InitializeComponent();
            mainWorker = new MainWorker();

            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }

        public void SetLikerTaskInfo()
        {
            lblTaskTarget.Text = mainWorker.CurrentTask.TargetLogin;
            lblProgressCommonCount.Text = mainWorker.CurrentTask.LikesCount.ToString();

            btnStart.Enabled = true;
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
            var bw = new BackgroundWorker();
            bw.RunWorkerCompleted += LiginInAccsComplete;
            bw.DoWork += LoginInAccs;
            DisableButtons();
            lblWorkStatus.ForeColor = Color.OrangeRed;
            lblWorkStatus.Text = "Логинимся в аккаунты";
            bw.RunWorkerAsync();
        }

        private void DisableButtons()
        {
            btnAddAccs.Enabled = false;
            btnLoginAccs.Enabled = false;
            btnAddTask.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }

        private void EnableButtonsWithoutStartStop()
        {
            btnAddTask.Enabled = true;
            btnAddAccs.Enabled = true;
            btnLoginAccs.Enabled = true;
        }

        private void LoginInAccs(object sender, DoWorkEventArgs e)
        {
            e.Result = mainWorker.LoginInAccs();
        }

        private void LiginInAccsComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            lblWorkStatus.ForeColor = Color.Green;
            lblWorkStatus.Text = "Свободно";
            EnableButtonsWithoutStartStop();
            lblAccountsLoggedIn.Text = e.Result.ToString();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm(mainWorker, this);
            addTaskForm.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += Start;
            bw.RunWorkerCompleted += LikerComplete;
            bw.ProgressChanged += LikerProgress;
            lblWorkStatus.ForeColor = Color.OrangeRed;
            lblWorkStatus.Text = "Крутим";
            DisableButtons();
            btnStop.Enabled = true;
            bw.RunWorkerAsync();
        }

        private void Start(object sender, DoWorkEventArgs e)
        {
            mainWorker.Start(sender as BackgroundWorker);
        }

        private void LikerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableButtonsWithoutStartStop();
            lblWorkStatus.ForeColor = Color.Green;
            lblWorkStatus.Text = "Свободно";
            MessageBox.Show("Накрутка заверешена!");
        }

        public void LikerProgress(object sender, ProgressChangedEventArgs e)
        {
            lblTaskProgress.Text = ((int)e.UserState).ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mainWorker.Stop();
            btnStop.Enabled = false;
        }
    }
}