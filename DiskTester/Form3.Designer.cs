namespace DiskTester
{
    partial class Form3
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
            this.groupBoxControl2 = new System.Windows.Forms.GroupBox();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.buttonRefresh2 = new System.Windows.Forms.Button();
            this.labelDestTitle2 = new System.Windows.Forms.Label();
            this.comboBoxDest2 = new System.Windows.Forms.ComboBox();
            this.groupBoxStatus2 = new System.Windows.Forms.GroupBox();
            this.labelDetail2 = new System.Windows.Forms.Label();
            this.labelDetailMessage2 = new System.Windows.Forms.Label();
            this.labelProgress2 = new System.Windows.Forms.Label();
            this.labelProgressMessage2 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.progressBarExpandedTest = new System.Windows.Forms.ProgressBar();
            this.groupBoxControl2.SuspendLayout();
            this.groupBoxStatus2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControl2
            // 
            this.groupBoxControl2.Controls.Add(this.buttonStart2);
            this.groupBoxControl2.Controls.Add(this.buttonRefresh2);
            this.groupBoxControl2.Controls.Add(this.labelDestTitle2);
            this.groupBoxControl2.Controls.Add(this.comboBoxDest2);
            this.groupBoxControl2.Font = new System.Drawing.Font("SimSun", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxControl2.Location = new System.Drawing.Point(12, 11);
            this.groupBoxControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControl2.Name = "groupBoxControl2";
            this.groupBoxControl2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControl2.Size = new System.Drawing.Size(567, 87);
            this.groupBoxControl2.TabIndex = 5;
            this.groupBoxControl2.TabStop = false;
            this.groupBoxControl2.Text = "选择目标磁盘";
            // 
            // buttonStart2
            // 
            this.buttonStart2.Location = new System.Drawing.Point(332, 26);
            this.buttonStart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(208, 38);
            this.buttonStart2.TabIndex = 5;
            this.buttonStart2.Text = "选择并开始";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // buttonRefresh2
            // 
            this.buttonRefresh2.Location = new System.Drawing.Point(215, 25);
            this.buttonRefresh2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh2.Name = "buttonRefresh2";
            this.buttonRefresh2.Size = new System.Drawing.Size(98, 38);
            this.buttonRefresh2.TabIndex = 4;
            this.buttonRefresh2.Text = "刷新";
            this.buttonRefresh2.UseVisualStyleBackColor = true;
            this.buttonRefresh2.Click += new System.EventHandler(this.buttonRefresh2_Click);
            // 
            // labelDestTitle2
            // 
            this.labelDestTitle2.AutoSize = true;
            this.labelDestTitle2.Location = new System.Drawing.Point(18, 37);
            this.labelDestTitle2.Name = "labelDestTitle2";
            this.labelDestTitle2.Size = new System.Drawing.Size(94, 21);
            this.labelDestTitle2.TabIndex = 3;
            this.labelDestTitle2.Text = "设置到：";
            // 
            // comboBoxDest2
            // 
            this.comboBoxDest2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDest2.FormattingEnabled = true;
            this.comboBoxDest2.Location = new System.Drawing.Point(115, 34);
            this.comboBoxDest2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDest2.Name = "comboBoxDest2";
            this.comboBoxDest2.Size = new System.Drawing.Size(81, 29);
            this.comboBoxDest2.TabIndex = 2;
            // 
            // groupBoxStatus2
            // 
            this.groupBoxStatus2.Controls.Add(this.labelDetail2);
            this.groupBoxStatus2.Controls.Add(this.labelDetailMessage2);
            this.groupBoxStatus2.Controls.Add(this.labelProgress2);
            this.groupBoxStatus2.Controls.Add(this.labelProgressMessage2);
            this.groupBoxStatus2.Controls.Add(this.labelStatus2);
            this.groupBoxStatus2.Controls.Add(this.labelMessage2);
            this.groupBoxStatus2.Font = new System.Drawing.Font("SimSun", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxStatus2.Location = new System.Drawing.Point(12, 106);
            this.groupBoxStatus2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStatus2.Name = "groupBoxStatus2";
            this.groupBoxStatus2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStatus2.Size = new System.Drawing.Size(567, 264);
            this.groupBoxStatus2.TabIndex = 7;
            this.groupBoxStatus2.TabStop = false;
            this.groupBoxStatus2.Text = "状态";
            // 
            // labelDetail2
            // 
            this.labelDetail2.AutoSize = true;
            this.labelDetail2.Location = new System.Drawing.Point(99, 150);
            this.labelDetail2.Name = "labelDetail2";
            this.labelDetail2.Size = new System.Drawing.Size(94, 21);
            this.labelDetail2.TabIndex = 8;
            this.labelDetail2.Text = "未开始！";
            // 
            // labelDetailMessage2
            // 
            this.labelDetailMessage2.AutoSize = true;
            this.labelDetailMessage2.Location = new System.Drawing.Point(18, 150);
            this.labelDetailMessage2.Name = "labelDetailMessage2";
            this.labelDetailMessage2.Size = new System.Drawing.Size(73, 21);
            this.labelDetailMessage2.TabIndex = 7;
            this.labelDetailMessage2.Text = "详情：";
            // 
            // labelProgress2
            // 
            this.labelProgress2.AutoSize = true;
            this.labelProgress2.Location = new System.Drawing.Point(99, 94);
            this.labelProgress2.Name = "labelProgress2";
            this.labelProgress2.Size = new System.Drawing.Size(94, 21);
            this.labelProgress2.TabIndex = 6;
            this.labelProgress2.Text = "未开始！";
            // 
            // labelProgressMessage2
            // 
            this.labelProgressMessage2.AutoSize = true;
            this.labelProgressMessage2.Location = new System.Drawing.Point(18, 94);
            this.labelProgressMessage2.Name = "labelProgressMessage2";
            this.labelProgressMessage2.Size = new System.Drawing.Size(73, 21);
            this.labelProgressMessage2.TabIndex = 5;
            this.labelProgressMessage2.Text = "进度：";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStatus2.Location = new System.Drawing.Point(97, 32);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(62, 31);
            this.labelStatus2.TabIndex = 4;
            this.labelStatus2.Text = "未知";
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Location = new System.Drawing.Point(18, 37);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(73, 21);
            this.labelMessage2.TabIndex = 3;
            this.labelMessage2.Text = "信息：";
            // 
            // progressBarExpandedTest
            // 
            this.progressBarExpandedTest.Location = new System.Drawing.Point(13, 379);
            this.progressBarExpandedTest.Name = "progressBarExpandedTest";
            this.progressBarExpandedTest.Size = new System.Drawing.Size(566, 38);
            this.progressBarExpandedTest.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 428);
            this.Controls.Add(this.progressBarExpandedTest);
            this.Controls.Add(this.groupBoxStatus2);
            this.Controls.Add(this.groupBoxControl2);
            this.Name = "Form3";
            this.Text = "老化测试";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBoxControl2.ResumeLayout(false);
            this.groupBoxControl2.PerformLayout();
            this.groupBoxStatus2.ResumeLayout(false);
            this.groupBoxStatus2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControl2;
        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.Button buttonRefresh2;
        private System.Windows.Forms.Label labelDestTitle2;
        private System.Windows.Forms.ComboBox comboBoxDest2;
        private System.Windows.Forms.GroupBox groupBoxStatus2;
        private System.Windows.Forms.Label labelDetail2;
        private System.Windows.Forms.Label labelDetailMessage2;
        private System.Windows.Forms.Label labelProgress2;
        private System.Windows.Forms.Label labelProgressMessage2;
        private System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.Label labelMessage2;
        private System.Windows.Forms.ProgressBar progressBarExpandedTest;
    }
}