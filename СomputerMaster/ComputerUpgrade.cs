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
    public partial class FormComputerWorks : Form
    {
        public FormMainMenu mainMenu;
        public FormComputerWorks(FormMainMenu MainMenu)
        {
            InitializeComponent();
            mainMenu = MainMenu;
        }
        public FormComputerWorks()
        {
            InitializeComponent();
        }

        private void ComputersBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComputerUpgrade_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 9)
            {

                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 10;
                Properties.Settings.Default.Computer = "Куплено";
                MessageBox.Show("Успешно проапгрейжено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComputerUpgrade.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MemoryUpgrade_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 19)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 20;
                Properties.Settings.Default.Memory = "Куплено";
                MessageBox.Show("Успешно проапгрейжено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MemoryUpgrade.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 5;
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeCD_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 39)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 40;
                Properties.Settings.Default.HardDrive = "Куплено";
                MessageBox.Show("Успешно проапгрейжено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpgradeCD.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 7;
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModemUpgrade_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 59)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 60;
                Properties.Settings.Default.Modem = "Куплено";
                MessageBox.Show("Успешно проапгрейжено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ModemUpgrade.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 10;
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeCDROM_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 79)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 80;
                Properties.Settings.Default.CDROM = "Куплено";
                MessageBox.Show("Успешно проапгрейжено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpgradeCDROM.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 15;
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoundBlasterBuy_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 99)
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 100;
                Properties.Settings.Default.SoundBlaster = "Куплено";
                MessageBox.Show("Успешно проапгрейжено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoundBlasterBuy.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 20;
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ComputerUpgrade_Move(object sender, MouseEventArgs e)
        {
            DiscriptionUpgrade.Text = "Вам это обойдётся в 10$";
        }

        private void MemoryUpgrade_MouseMove(object sender, MouseEventArgs e)
        {
            DiscriptionUpgrade.Text = "Вам это обойдётся в 20$";
        }

        private void UpgradeCD_MouseMove(object sender, MouseEventArgs e)
        {
            DiscriptionUpgrade.Text = "Вам это обойдётся в 40$";
        }

        private void ModemUpgrade_MouseMove(object sender, MouseEventArgs e)
        {
            DiscriptionUpgrade.Text = "Вам это обойдётся в 60$";
        }

        private void UpgradeCDROM_MouseMove(object sender, MouseEventArgs e)
        {
            DiscriptionUpgrade.Text = "Вам это обойдётся в 80$";
        }

        private void SoundBlasterBuy_MouseMove(object sender, MouseEventArgs e)
        {
            DiscriptionUpgrade.Text = "Вам это обойдётся в 100$";
        }

        private void FormComputerWorks_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Computer == "Куплено")
            {
                ComputerUpgrade.Enabled = false;
            }
            if (Properties.Settings.Default.Memory == "Куплено")
            {
                MemoryUpgrade.Enabled = false;
            }
            if (Properties.Settings.Default.HardDrive == "Куплено")
            {
                UpgradeCD.Enabled = false;
            }
            if (Properties.Settings.Default.Modem == "Куплено")
            {
                ModemUpgrade.Enabled = false;
            }
            if (Properties.Settings.Default.CDROM == "Куплено")
            {
                UpgradeCDROM.Enabled = false;
            }
            if (Properties.Settings.Default.SoundBlaster == "Куплено")
            {
                SoundBlasterBuy.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
