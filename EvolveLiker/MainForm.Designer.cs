namespace EvolveLiker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoginAccs = new System.Windows.Forms.Button();
            this.btnAddAccs = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.lblWorkStatus = new System.Windows.Forms.Label();
            this.lblProgressCommonCount = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.lblTaskProgress = new System.Windows.Forms.Label();
            this.lblTaskTarget = new System.Windows.Forms.Label();
            this.lblAccountsLoggedIn = new System.Windows.Forms.Label();
            this.lblAccountsCount = new System.Windows.Forms.Label();
            this.lblWorkStatusText = new System.Windows.Forms.Label();
            this.lblTaskProgressText = new System.Windows.Forms.Label();
            this.lblTaskTargetText = new System.Windows.Forms.Label();
            this.lblAccountsLoggedInText = new System.Windows.Forms.Label();
            this.lblAccountsCountText = new System.Windows.Forms.Label();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginAccs
            // 
            this.btnLoginAccs.Location = new System.Drawing.Point(12, 41);
            this.btnLoginAccs.Name = "btnLoginAccs";
            this.btnLoginAccs.Size = new System.Drawing.Size(161, 23);
            this.btnLoginAccs.TabIndex = 0;
            this.btnLoginAccs.Text = "Залогиниться в аккаунты";
            this.btnLoginAccs.UseVisualStyleBackColor = true;
            this.btnLoginAccs.Click += new System.EventHandler(this.btnLoginAccs_Click);
            // 
            // btnAddAccs
            // 
            this.btnAddAccs.Location = new System.Drawing.Point(12, 12);
            this.btnAddAccs.Name = "btnAddAccs";
            this.btnAddAccs.Size = new System.Drawing.Size(161, 23);
            this.btnAddAccs.TabIndex = 1;
            this.btnAddAccs.Text = "Добавить аккаунты";
            this.btnAddAccs.UseVisualStyleBackColor = true;
            this.btnAddAccs.Click += new System.EventHandler(this.btnAddAccs_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(12, 70);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(161, 23);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Новая задача";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 148);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.lblWorkStatus);
            this.infoBox.Controls.Add(this.lblProgressCommonCount);
            this.infoBox.Controls.Add(this.lblSlash);
            this.infoBox.Controls.Add(this.lblTaskProgress);
            this.infoBox.Controls.Add(this.lblTaskTarget);
            this.infoBox.Controls.Add(this.lblAccountsLoggedIn);
            this.infoBox.Controls.Add(this.lblAccountsCount);
            this.infoBox.Controls.Add(this.lblWorkStatusText);
            this.infoBox.Controls.Add(this.lblTaskProgressText);
            this.infoBox.Controls.Add(this.lblTaskTargetText);
            this.infoBox.Controls.Add(this.lblAccountsLoggedInText);
            this.infoBox.Controls.Add(this.lblAccountsCountText);
            this.infoBox.Location = new System.Drawing.Point(179, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(227, 159);
            this.infoBox.TabIndex = 5;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Информация";
            // 
            // lblWorkStatus
            // 
            this.lblWorkStatus.AutoSize = true;
            this.lblWorkStatus.ForeColor = System.Drawing.Color.Green;
            this.lblWorkStatus.Location = new System.Drawing.Point(137, 109);
            this.lblWorkStatus.Name = "lblWorkStatus";
            this.lblWorkStatus.Size = new System.Drawing.Size(56, 13);
            this.lblWorkStatus.TabIndex = 11;
            this.lblWorkStatus.Text = "Свободно";
            // 
            // lblProgressCommonCount
            // 
            this.lblProgressCommonCount.AutoSize = true;
            this.lblProgressCommonCount.Location = new System.Drawing.Point(191, 89);
            this.lblProgressCommonCount.Name = "lblProgressCommonCount";
            this.lblProgressCommonCount.Size = new System.Drawing.Size(13, 13);
            this.lblProgressCommonCount.TabIndex = 10;
            this.lblProgressCommonCount.Text = "0";
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Location = new System.Drawing.Point(167, 89);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(12, 13);
            this.lblSlash.TabIndex = 9;
            this.lblSlash.Text = "/";
            // 
            // lblTaskProgress
            // 
            this.lblTaskProgress.AutoSize = true;
            this.lblTaskProgress.Location = new System.Drawing.Point(137, 89);
            this.lblTaskProgress.Name = "lblTaskProgress";
            this.lblTaskProgress.Size = new System.Drawing.Size(13, 13);
            this.lblTaskProgress.TabIndex = 8;
            this.lblTaskProgress.Text = "0";
            // 
            // lblTaskTarget
            // 
            this.lblTaskTarget.AutoSize = true;
            this.lblTaskTarget.Location = new System.Drawing.Point(137, 69);
            this.lblTaskTarget.Name = "lblTaskTarget";
            this.lblTaskTarget.Size = new System.Drawing.Size(50, 13);
            this.lblTaskTarget.TabIndex = 7;
            this.lblTaskTarget.Text = "No name";
            // 
            // lblAccountsLoggedIn
            // 
            this.lblAccountsLoggedIn.AutoSize = true;
            this.lblAccountsLoggedIn.Location = new System.Drawing.Point(137, 49);
            this.lblAccountsLoggedIn.Name = "lblAccountsLoggedIn";
            this.lblAccountsLoggedIn.Size = new System.Drawing.Size(13, 13);
            this.lblAccountsLoggedIn.TabIndex = 6;
            this.lblAccountsLoggedIn.Text = "0";
            // 
            // lblAccountsCount
            // 
            this.lblAccountsCount.AutoSize = true;
            this.lblAccountsCount.Location = new System.Drawing.Point(137, 29);
            this.lblAccountsCount.Name = "lblAccountsCount";
            this.lblAccountsCount.Size = new System.Drawing.Size(13, 13);
            this.lblAccountsCount.TabIndex = 5;
            this.lblAccountsCount.Text = "0";
            // 
            // lblWorkStatusText
            // 
            this.lblWorkStatusText.AutoSize = true;
            this.lblWorkStatusText.Location = new System.Drawing.Point(6, 109);
            this.lblWorkStatusText.Name = "lblWorkStatusText";
            this.lblWorkStatusText.Size = new System.Drawing.Size(64, 13);
            this.lblWorkStatusText.TabIndex = 4;
            this.lblWorkStatusText.Text = "Состояние:";
            // 
            // lblTaskProgressText
            // 
            this.lblTaskProgressText.AutoSize = true;
            this.lblTaskProgressText.Location = new System.Drawing.Point(6, 89);
            this.lblTaskProgressText.Name = "lblTaskProgressText";
            this.lblTaskProgressText.Size = new System.Drawing.Size(53, 13);
            this.lblTaskProgressText.TabIndex = 3;
            this.lblTaskProgressText.Text = "Сделано:";
            // 
            // lblTaskTargetText
            // 
            this.lblTaskTargetText.AutoSize = true;
            this.lblTaskTargetText.Location = new System.Drawing.Point(6, 69);
            this.lblTaskTargetText.Name = "lblTaskTargetText";
            this.lblTaskTargetText.Size = new System.Drawing.Size(75, 13);
            this.lblTaskTargetText.TabIndex = 2;
            this.lblTaskTargetText.Text = "Кому крутим:";
            // 
            // lblAccountsLoggedInText
            // 
            this.lblAccountsLoggedInText.AutoSize = true;
            this.lblAccountsLoggedInText.Location = new System.Drawing.Point(6, 49);
            this.lblAccountsLoggedInText.Name = "lblAccountsLoggedInText";
            this.lblAccountsLoggedInText.Size = new System.Drawing.Size(125, 13);
            this.lblAccountsLoggedInText.TabIndex = 1;
            this.lblAccountsLoggedInText.Text = "Аккаунтов залогинено:";
            // 
            // lblAccountsCountText
            // 
            this.lblAccountsCountText.AutoSize = true;
            this.lblAccountsCountText.Location = new System.Drawing.Point(6, 29);
            this.lblAccountsCountText.Name = "lblAccountsCountText";
            this.lblAccountsCountText.Size = new System.Drawing.Size(63, 13);
            this.lblAccountsCountText.TabIndex = 0;
            this.lblAccountsCountText.Text = "Аккаунтов:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 185);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnAddAccs);
            this.Controls.Add(this.btnLoginAccs);
            this.Name = "MainForm";
            this.Text = "EvolveLiker by TABOR";
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginAccs;
        private System.Windows.Forms.Button btnAddAccs;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label lblTaskProgressText;
        private System.Windows.Forms.Label lblTaskTargetText;
        private System.Windows.Forms.Label lblAccountsLoggedInText;
        private System.Windows.Forms.Label lblAccountsCountText;
        private System.Windows.Forms.Label lblAccountsCount;
        private System.Windows.Forms.Label lblWorkStatusText;
        private System.Windows.Forms.Label lblWorkStatus;
        private System.Windows.Forms.Label lblProgressCommonCount;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.Label lblTaskProgress;
        private System.Windows.Forms.Label lblTaskTarget;
        private System.Windows.Forms.Label lblAccountsLoggedIn;
    }
}

