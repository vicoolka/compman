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
    public partial class FormProgrammInstall : Form
    {
        public FormMainMenu mainMenu;
        public FormProgrammInstall(FormMainMenu MainMenu)
        {
            InitializeComponent();
            mainMenu = MainMenu;
        }
        public FormProgrammInstall()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProgrammInstallBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyAntivirus_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Вы можете приобрести антивирус за 20$, если у вас Windows NT или новее. Потихоньку убирает ненужный софт";
        }

        private void UpgradeWindows1_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Вы можете накатить Windows 3, если у вас куплен компьютер";
        }

        private void BuyAntivirus_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount > 19 && (Properties.Settings.Default.System == "OS 2/5.0 Warp" || Properties.Settings.Default.System == "Windows NT"))
            {
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 20;
                Properties.Settings.Default.AntiVirus = "Куплено";
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 5;

                MessageBox.Show("Успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuyAntivirus.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeWindows1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Computer == "Куплено")
            {
                Properties.Settings.Default.System = "Windows 3";
                MessageBox.Show("Успешно Накатилась", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpgradeWindows1.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
            }
            else
            {
                MessageBox.Show("Недоступно" , "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeWindows2_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Вы можете накатить Windows 95, если у вас куплен компьютер и память";
        }

        private void UpgradeWindows3_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Вы можете накатить Windows NT, если у вас куплен компьютер, память и винчестер";
        }

        private void UpgradeWindows4_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Вы можете накатить OS 2 / 5.0 Warp, если у вас куплен компьютер, память, винчестер и CD-ROM"; 
        }

        private void UpgradeWindows2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Computer == "Куплено" && Properties.Settings.Default.Memory == "Куплено")
            {
                Properties.Settings.Default.System = "Windows 95";
                MessageBox.Show("Успешно Накатилась", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpgradeWindows1.Enabled = false;
                UpgradeWindows2.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 5;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeWindows3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Computer == "Куплено" && Properties.Settings.Default.Memory == "Куплено" && Properties.Settings.Default.HardDrive == "Куплено")
            {
                Properties.Settings.Default.System = "Windows NT";
                MessageBox.Show("Успешно Накатилась", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpgradeWindows1.Enabled = false;
                UpgradeWindows2.Enabled = false;
                UpgradeWindows3.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 7;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeWindows4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Computer == "Куплено" && Properties.Settings.Default.Memory == "Куплено" && Properties.Settings.Default.HardDrive == "Куплено" && Properties.Settings.Default.CDROM == "Куплено")
            {
                Properties.Settings.Default.System = "OS 2/5.0 Warp";
                MessageBox.Show("Успешно Накатилась", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpgradeWindows1.Enabled = false;
                UpgradeWindows2.Enabled = false;
                UpgradeWindows3.Enabled = false;
                UpgradeWindows4.Enabled = false;
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 10;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradePascal_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.HardDrive == "Куплено")
            {
                Properties.Settings.Default.Programming = "Pascal";
                UpgradePascal.Enabled= false;
                MessageBox.Show("Язык изучен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;

            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProgrammInstall_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Programming == "Pascal")
            {
                UpgradePascal.Enabled = false;
            }
            if (Properties.Settings.Default.Programming == "Assembler")
            {
                UpgradePascal.Enabled = false;
                UpgradeAssembler.Enabled = false;
            }
            if (Properties.Settings.Default.Programming == "VisualBasic")
            {
                UpgradePascal.Enabled = false;
                UpgradeAssembler.Enabled = false;
                UpgradeVisualBasic.Enabled = false;
            }
            if (Properties.Settings.Default.Programming == "Delphi")
            {
                UpgradePascal.Enabled = false;
                UpgradeAssembler.Enabled = false;
                UpgradeVisualBasic.Enabled = false;
                UpgradeDelphi.Enabled = false;
            }
            if (Properties.Settings.Default.System == "Windows 3")
            {
                UpgradeWindows1.Enabled = false;
            }
            if (Properties.Settings.Default.System == "Windows 95")
            {
                UpgradeWindows1.Enabled = false;
                UpgradeWindows2.Enabled = false;
            }
            if (Properties.Settings.Default.System == "Windows NT")
            {
                UpgradeWindows1.Enabled = false;
                UpgradeWindows2.Enabled = false;
                UpgradeWindows3.Enabled = false;
            }
            if (Properties.Settings.Default.System == "OS 2/5.0 Warp")
            {
                UpgradeWindows1.Enabled = false;
                UpgradeWindows2.Enabled = false;
                UpgradeWindows3.Enabled = false;
                UpgradeWindows4.Enabled = false;
            }
            if (Properties.Settings.Default.AntiVirus == "Куплено")
            {
                BuyAntivirus.Enabled = false;
            }

        }

        private void UpgradeAssembler_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.HardDrive == "Куплено" && Properties.Settings.Default.CDROM == "Куплено")
            {
                Properties.Settings.Default.Programming = "Assembler";
                UpgradePascal.Enabled = false;
                UpgradeAssembler.Enabled = false;
                MessageBox.Show("Язык изучен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 5;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeVisualBasic_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.HardDrive == "Куплено" && Properties.Settings.Default.CDROM == "Куплено" && Properties.Settings.Default.Modem == "Куплено")
            {
                Properties.Settings.Default.Programming = "VisualBasic";
                UpgradePascal.Enabled = false;
                UpgradeAssembler.Enabled = false;
                UpgradeVisualBasic.Enabled = false;
                MessageBox.Show("Язык изучен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 7;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradeDelphi_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.HardDrive == "Куплено" && Properties.Settings.Default.CDROM == "Куплено" && Properties.Settings.Default.Modem == "Куплено" && Properties.Settings.Default.SoundBlaster == "Куплено")
            {
                Properties.Settings.Default.Programming = "Delphi";
                UpgradePascal.Enabled = false;
                UpgradeAssembler.Enabled = false;
                UpgradeVisualBasic.Enabled = false;
                UpgradeDelphi.Enabled = false;
                MessageBox.Show("Язык изучен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.Point = Properties.Settings.Default.Point + 10;
            }
            else
            {
                MessageBox.Show("Недоступно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgradePascal_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Для этого вам нужно приобрести жёсткий диск";
        }

        private void UpgradeAssembler_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Для этого вам нужно приобрести жёсткий диск и дисковод";
        }

        private void UpgradeVisualBasic_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Для этого вам нужно приобрести жёсткий диск, модем и дисковод";
        }

        private void UpgradeDelphi_MouseMove(object sender, MouseEventArgs e)
        {
            ProgrammsDiscriptions.Text = "Для этого вам нужно приобрести жёсткий диск, модем, дисковод и звуковая карта";
        }
    }
}
