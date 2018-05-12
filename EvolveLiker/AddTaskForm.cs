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
    public partial class AddTaskForm : Form
    {
        private MainWorker mainWorker;
        private MainForm parentForm;

        public AddTaskForm()
        {
            InitializeComponent();
        }

        public AddTaskForm(MainWorker mainWorker, MainForm parentForm)
            : this()
        {
            this.mainWorker = mainWorker;
            this.parentForm = parentForm;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var newTask = new LikerTask(txtTarget.Text,
                int.Parse(txtCount.Text), mainWorker.AccountContainer, mainWorker);

            foreach (var line in txtLinks.Lines)
            {
                newTask.AddUri(line);
            }

            mainWorker.SetLikerTask(newTask);
            parentForm.SetLikerTaskInfo();
            Close();
        }
    }
}
