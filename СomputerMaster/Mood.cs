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
    public partial class FormMood : Form
    {

        public FormMainMenu mainMenu;
        public FormMood(FormMainMenu MainMenu)
        {
            InitializeComponent();
            mainMenu = MainMenu;
        }
        public FormMood()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MoodBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComputerWorks_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 4)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 5;
                Properties.Settings.Default.MoodCount = Properties.Settings.Default.MoodCount + 20;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
                MessageBox.Show("Хорошо отдохнули", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Properties.Settings.Default.MoodCount = 30;
            }
        }

        private void Programms_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 19)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 20;
                Properties.Settings.Default.MoodCount = Properties.Settings.Default.MoodCount + 60;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
                MessageBox.Show("Хорошо отдохнули", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Properties.Settings.Default.MoodCount = 30;
            }
        }

        private void WorkBBS_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 29)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 30;
                Properties.Settings.Default.MoodCount = Properties.Settings.Default.MoodCount + 120;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
                MessageBox.Show("Хорошо отдохнули", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Properties.Settings.Default.MoodCount = 30;
            }
        }

        private void FormMood_Load(object sender, EventArgs e)
        {

        }
    }
}
