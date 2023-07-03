namespace СomputerMaster
{
    partial class FormBBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBBS));
            this.CallTOBBS = new System.Windows.Forms.Button();
            this.CreateBBS = new System.Windows.Forms.Button();
            this.textBoxBBS = new System.Windows.Forms.TextBox();
            this.BBSBack = new System.Windows.Forms.Button();
            this.BBSDiscriptoin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CallTOBBS
            // 
            this.CallTOBBS.BackColor = System.Drawing.SystemColors.Control;
            this.CallTOBBS.Location = new System.Drawing.Point(35, 31);
            this.CallTOBBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CallTOBBS.Name = "CallTOBBS";
            this.CallTOBBS.Size = new System.Drawing.Size(161, 43);
            this.CallTOBBS.TabIndex = 0;
            this.CallTOBBS.Text = "Звонить на SinsBBS";
            this.CallTOBBS.UseVisualStyleBackColor = false;
            this.CallTOBBS.Click += new System.EventHandler(this.CallTOBBS_Click);
            this.CallTOBBS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CallTOBBS_MouseMove);
            // 
            // CreateBBS
            // 
            this.CreateBBS.BackColor = System.Drawing.SystemColors.Control;
            this.CreateBBS.Location = new System.Drawing.Point(35, 92);
            this.CreateBBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateBBS.Name = "CreateBBS";
            this.CreateBBS.Size = new System.Drawing.Size(161, 43);
            this.CreateBBS.TabIndex = 1;
            this.CreateBBS.Text = "Создать свою";
            this.CreateBBS.UseVisualStyleBackColor = false;
            this.CreateBBS.Click += new System.EventHandler(this.CreateBBS_Click);
            this.CreateBBS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreateBBS_MouseMove);
            // 
            // textBoxBBS
            // 
            this.textBoxBBS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBBS.Location = new System.Drawing.Point(35, 158);
            this.textBoxBBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBBS.Name = "textBoxBBS";
            this.textBoxBBS.Size = new System.Drawing.Size(161, 22);
            this.textBoxBBS.TabIndex = 2;
            // 
            // BBSBack
            // 
            this.BBSBack.BackColor = System.Drawing.SystemColors.Control;
            this.BBSBack.Location = new System.Drawing.Point(232, 137);
            this.BBSBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBSBack.Name = "BBSBack";
            this.BBSBack.Size = new System.Drawing.Size(160, 43);
            this.BBSBack.TabIndex = 3;
            this.BBSBack.Text = "Вернуться";
            this.BBSBack.UseVisualStyleBackColor = false;
            this.BBSBack.Click += new System.EventHandler(this.BBSBack_Click);
            // 
            // BBSDiscriptoin
            // 
            this.BBSDiscriptoin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BBSDiscriptoin.Location = new System.Drawing.Point(232, 31);
            this.BBSDiscriptoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBSDiscriptoin.Name = "BBSDiscriptoin";
            this.BBSDiscriptoin.Size = new System.Drawing.Size(160, 96);
            this.BBSDiscriptoin.TabIndex = 4;
            this.BBSDiscriptoin.Text = "";
            // 
            // FormBBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(428, 209);
            this.Controls.Add(this.BBSDiscriptoin);
            this.Controls.Add(this.BBSBack);
            this.Controls.Add(this.textBoxBBS);
            this.Controls.Add(this.CreateBBS);
            this.Controls.Add(this.CallTOBBS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CallTOBBS;
        private System.Windows.Forms.Button CreateBBS;
        private System.Windows.Forms.TextBox textBoxBBS;
        private System.Windows.Forms.Button BBSBack;
        private System.Windows.Forms.RichTextBox BBSDiscriptoin;
    }
}