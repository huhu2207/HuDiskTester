namespace DiskTester
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelDestTitle = new System.Windows.Forms.Label();
            this.comboBoxDest = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBarExpandedTest = new System.Windows.Forms.ProgressBar();
            this.labelProgressMessage = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelDetailMessage = new System.Windows.Forms.Label();
            this.groupBoxControl.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.buttonStart);
            this.groupBoxControl.Controls.Add(this.buttonRefresh);
            this.groupBoxControl.Controls.Add(this.labelDestTitle);
            this.groupBoxControl.Controls.Add(this.comboBoxDest);
            this.groupBoxControl.Font = new System.Drawing.Font("SimSun", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxControl.Location = new System.Drawing.Point(12, 11);
            this.groupBoxControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControl.Size = new System.Drawing.Size(567, 87);
            this.groupBoxControl.TabIndex = 4;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "选择目标磁盘";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(215, 25);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(98, 38);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelDestTitle
            // 
            this.labelDestTitle.AutoSize = true;
            this.labelDestTitle.Location = new System.Drawing.Point(18, 37);
            this.labelDestTitle.Name = "labelDestTitle";
            this.labelDestTitle.Size = new System.Drawing.Size(94, 21);
            this.labelDestTitle.TabIndex = 3;
            this.labelDestTitle.Text = "设置到：";
            // 
            // comboBoxDest
            // 
            this.comboBoxDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDest.FormattingEnabled = true;
            this.comboBoxDest.Location = new System.Drawing.Point(115, 34);
            this.comboBoxDest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDest.Name = "comboBoxDest";
            this.comboBoxDest.Size = new System.Drawing.Size(81, 29);
            this.comboBoxDest.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(332, 26);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(208, 38);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "选择并开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.labelDetail);
            this.groupBoxStatus.Controls.Add(this.labelDetailMessage);
            this.groupBoxStatus.Controls.Add(this.labelProgress);
            this.groupBoxStatus.Controls.Add(this.labelProgressMessage);
            this.groupBoxStatus.Controls.Add(this.labelStatus);
            this.groupBoxStatus.Controls.Add(this.labelMessage);
            this.groupBoxStatus.Font = new System.Drawing.Font("SimSun", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxStatus.Location = new System.Drawing.Point(12, 104);
            this.groupBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStatus.Size = new System.Drawing.Size(567, 264);
            this.groupBoxStatus.TabIndex = 6;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "状态";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(18, 37);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(73, 21);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "信息：";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStatus.Location = new System.Drawing.Point(97, 32);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(62, 31);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "未知";
            // 
            // progressBarExpandedTest
            // 
            this.progressBarExpandedTest.Location = new System.Drawing.Point(13, 378);
            this.progressBarExpandedTest.Name = "progressBarExpandedTest";
            this.progressBarExpandedTest.Size = new System.Drawing.Size(566, 38);
            this.progressBarExpandedTest.TabIndex = 7;
            // 
            // labelProgressMessage
            // 
            this.labelProgressMessage.AutoSize = true;
            this.labelProgressMessage.Location = new System.Drawing.Point(18, 94);
            this.labelProgressMessage.Name = "labelProgressMessage";
            this.labelProgressMessage.Size = new System.Drawing.Size(73, 21);
            this.labelProgressMessage.TabIndex = 5;
            this.labelProgressMessage.Text = "进度：";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(99, 94);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(94, 21);
            this.labelProgress.TabIndex = 6;
            this.labelProgress.Text = "未开始！";
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(99, 150);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(94, 21);
            this.labelDetail.TabIndex = 8;
            this.labelDetail.Text = "未开始！";
            // 
            // labelDetailMessage
            // 
            this.labelDetailMessage.AutoSize = true;
            this.labelDetailMessage.Location = new System.Drawing.Point(18, 150);
            this.labelDetailMessage.Name = "labelDetailMessage";
            this.labelDetailMessage.Size = new System.Drawing.Size(73, 21);
            this.labelDetailMessage.TabIndex = 7;
            this.labelDetailMessage.Text = "详情：";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 429);
            this.Controls.Add(this.progressBarExpandedTest);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxControl);
            this.Name = "Form2";
            this.Text = "扩容测试";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelDestTitle;
        private System.Windows.Forms.ComboBox comboBoxDest;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelProgressMessage;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ProgressBar progressBarExpandedTest;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label labelDetailMessage;
    }
}