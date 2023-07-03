using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СomputerMaster
{
    public partial class FormBBS : Form
    {
        public FormBBS()
        {
            InitializeComponent();
        }

        private void BBSBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBBS_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Modem == "Куплено" && Properties.Settings.Default.Computer == "Куплено")
            {
                Properties.Settings.Default.BBS = "BBS создана";
                textBoxBBS.Text = Properties.Settings.Default.BBS;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
                CallTOBBS.Enabled = false;
                CreateBBS.Enabled = false;
            }
            else
            {   
                MessageBox.Show("Связь не ловит", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CallTOBBS_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ValueCall = random.Next(0, 4);
            if (ValueCall == 1)
            {
                textBoxBBS.Text = "Звонок удался";
                CallTOBBS.Enabled= false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
            }
            else
            {
                textBoxBBS.Text = "Связь прервалась";
            }

        }

        private void CallTOBBS_MouseMove(object sender, MouseEventArgs e)
        {
            BBSDiscriptoin.Text = "Связь может прерваться";
        }

        private void CreateBBS_MouseMove(object sender, MouseEventArgs e)
        {
            BBSDiscriptoin.Text = "Для этого вам нужен компьютер с модемом";
        }
    }
}
