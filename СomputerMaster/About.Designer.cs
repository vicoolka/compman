namespace СomputerMaster
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AboutBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(32, 42);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(228, 132);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Игра компьютерщик, в которой вы попробуете себя в роли компьютерного мастера. ";
            // 
            // AboutBack
            // 
            this.AboutBack.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AboutBack.Location = new System.Drawing.Point(32, 204);
            this.AboutBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutBack.Name = "AboutBack";
            this.AboutBack.Size = new System.Drawing.Size(228, 28);
            this.AboutBack.TabIndex = 4;
            this.AboutBack.Text = "Вернуться";
            this.AboutBack.UseVisualStyleBackColor = false;
            this.AboutBack.Click += new System.EventHandler(this.AboutBack_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(302, 276);
            this.Controls.Add(this.AboutBack);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AboutBack;
    }
}