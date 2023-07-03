namespace СomputerMaster
{
    partial class FormMood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMood));
            this.ComputerWorks = new System.Windows.Forms.Button();
            this.WorkBBS = new System.Windows.Forms.Button();
            this.Programms = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.MoodBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputerWorks
            // 
            this.ComputerWorks.BackColor = System.Drawing.SystemColors.Control;
            this.ComputerWorks.Location = new System.Drawing.Point(17, 23);
            this.ComputerWorks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComputerWorks.Name = "ComputerWorks";
            this.ComputerWorks.Size = new System.Drawing.Size(242, 38);
            this.ComputerWorks.TabIndex = 8;
            this.ComputerWorks.Text = "Сходить в гости - 5$";
            this.ComputerWorks.UseVisualStyleBackColor = false;
            this.ComputerWorks.Click += new System.EventHandler(this.ComputerWorks_Click);
            // 
            // WorkBBS
            // 
            this.WorkBBS.BackColor = System.Drawing.SystemColors.Control;
            this.WorkBBS.Location = new System.Drawing.Point(17, 137);
            this.WorkBBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WorkBBS.Name = "WorkBBS";
            this.WorkBBS.Size = new System.Drawing.Size(242, 38);
            this.WorkBBS.TabIndex = 10;
            this.WorkBBS.Text = "Игра в арканоид - 30$";
            this.WorkBBS.UseVisualStyleBackColor = false;
            this.WorkBBS.Click += new System.EventHandler(this.WorkBBS_Click);
            // 
            // Programms
            // 
            this.Programms.BackColor = System.Drawing.SystemColors.Control;
            this.Programms.Location = new System.Drawing.Point(17, 80);
            this.Programms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Programms.Name = "Programms";
            this.Programms.Size = new System.Drawing.Size(242, 38);
            this.Programms.TabIndex = 9;
            this.Programms.Text = "Баня с девушками - 20$";
            this.Programms.UseVisualStyleBackColor = false;
            this.Programms.Click += new System.EventHandler(this.Programms_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox2.Location = new System.Drawing.Point(321, 38);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(242, 38);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "Можете позволить себе отдохнуть";
            // 
            // MoodBack
            // 
            this.MoodBack.BackColor = System.Drawing.SystemColors.Control;
            this.MoodBack.Location = new System.Drawing.Point(321, 152);
            this.MoodBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoodBack.Name = "MoodBack";
            this.MoodBack.Size = new System.Drawing.Size(242, 38);
            this.MoodBack.TabIndex = 13;
            this.MoodBack.Text = "Вернуться";
            this.MoodBack.UseVisualStyleBackColor = false;
            this.MoodBack.Click += new System.EventHandler(this.MoodBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.ComputerWorks);
            this.groupBox1.Controls.Add(this.Programms);
            this.groupBox1.Controls.Add(this.WorkBBS);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(278, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // FormMood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(595, 223);
            this.Controls.Add(this.MoodBack);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Развлечения";
            this.Load += new System.EventHandler(this.FormMood_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComputerWorks;
        private System.Windows.Forms.Button WorkBBS;
        private System.Windows.Forms.Button Programms;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button MoodBack;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}