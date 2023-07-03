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
    public partial class FormWorkFind : Form
    {
        public FormMainMenu mainMenu;
        public FormWorkFind(FormMainMenu MainMenu)
        {
            InitializeComponent();
            mainMenu = MainMenu;
        }

        public FormWorkFind()
        {
            InitializeComponent();
        }

        private void WorkFindBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ComputerWorks_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Work = "Дворник";
            Properties.Settings.Default.MoneyWorking = 10;
            Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
            Work1.Enabled = false;
        }

        private void Programms_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Programming == "Pascal" || Properties.Settings.Default.Programming == "Assembler" || Properties.Settings.Default.Programming == "VisualBasic" || Properties.Settings.Default.Programming == "Delphi")
            {
                Properties.Settings.Default.Work = "Слесарь";
                Properties.Settings.Default.MoneyWorking = 20;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
                Work2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void WorkBBS_Click(object sender, EventArgs e)
        {
           if (Properties.Settings.Default.Programming == "Assembler" || Properties.Settings.Default.Programming == "VisualBasic" || Properties.Settings.Default.Programming == "Delphi")
            {
                Properties.Settings.Default.Work = "Программист";
                Properties.Settings.Default.MoneyWorking = 30;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
                Work3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindWork_Click(object sender, EventArgs e)
        {
           if (Properties.Settings.Default.Programming == "VisualBasic" || Properties.Settings.Default.Programming == "Delphi")
            {
                Properties.Settings.Default.Work = "Сис админ";
                Properties.Settings.Default.MoneyWorking = 40;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 5;
                Work4.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Happy_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Programming == "Delphi")
            {
                Properties.Settings.Default.Work = "Хакер";
                Properties.Settings.Default.MoneyWorking = 50;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 7;
                Work5.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComputerWorks_MouseMove(object sender, MouseEventArgs e)
        {
            WorkDiscriptions.Text = "Для этой работы вам не нужны навыки";
        }

        private void Programms_MouseMove(object sender, MouseEventArgs e)
        {
            WorkDiscriptions.Text = "Для этой работы вам нужны навыки паскаля";
        }

        private void WorkBBS_MouseMove(object sender, MouseEventArgs e)
        {
            WorkDiscriptions.Text = "Для этой работы вам нужны навыки ассемблера";
        }

        private void FindWork_MouseMove(object sender, MouseEventArgs e)
        {
            WorkDiscriptions.Text = "Для этой работы вам нужны навыки визуал бейсика";
        }

        private void Happy_MouseMove(object sender, MouseEventArgs e)
        {
            WorkDiscriptions.Text = "Для этой работы вам нужны навыки делфи";
        }

        private void FormWorkFind_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Work == "Дворник")
            {
                Work1.Enabled = false;
            }
            if (Properties.Settings.Default.Work == "Слесарь")
            {
                Work2.Enabled = false;
            }
            if (Properties.Settings.Default.Work == "Программист")
            {
                Work3.Enabled = false;
            }
            if (Properties.Settings.Default.Work == "Сис админ")
            {
                Work4.Enabled = false;
            }
            if (Properties.Settings.Default.Work == "Хакер")
            {
                Work5.Enabled = false;
            }
        }
    }
    
}
