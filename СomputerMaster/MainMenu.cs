using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace СomputerMaster
{
    
    public partial class FormMainMenu : Form
    {
        Thread LoadForm;
        YouLose youLose = new YouLose();
        YouWin youWin = new YouWin();
        int i = 0;
        /// <summary>
        /// Обновление всех данных формы
        /// </summary>
        public void updateMainForm()
        {
            MenuWork.Text = Properties.Settings.Default.Work + " / " + Convert.ToString(Properties.Settings.Default.MoneyWorking) + " / день";
            LabelComputer.Text = Properties.Settings.Default.Computer;
            LabelMemory.Text = Properties.Settings.Default.Memory;
            LabelHardDrive.Text = Properties.Settings.Default.HardDrive;
            LabelModem.Text = Properties.Settings.Default.Modem;
            LabelCDROM.Text = Properties.Settings.Default.CDROM;
            LabelSoundBlaster.Text = Properties.Settings.Default.SoundBlaster;
            LabelSystem.Text = Properties.Settings.Default.System;
            LabelAntiVirus.Text = Properties.Settings.Default.AntiVirus;
            LabelProgramming.Text = Properties.Settings.Default.Programming;
            LabelBBS.Text = Properties.Settings.Default.BBS;
            LabelMoneyCount.Text = Convert.ToString(Properties.Settings.Default.MoneyCount);
            LabelStatus.Text = Properties.Settings.Default.Status;
            LabelMood.Text = Properties.Settings.Default.Mood;
            LabelPoints.Text = Convert.ToString(Properties.Settings.Default.Point);
            labelOtherSoft.Text = Convert.ToString(Properties.Settings.Default.Soft);
            
        }

        public void OpenForm()
        {
            Application.Run(new FormMainMenu());
        }
        /// <summary>
        /// Концовка
        /// </summary>
        public void Winner()
        {
            if (Properties.Settings.Default.Status == "Хакер" && Properties.Settings.Default.MoneyCount > 99 && Properties.Settings.Default.Soft <= 1 && Properties.Settings.Default.Point >= 200)
            {
                TimerTime.Stop();
                youWin.Show();
            }
        }

        /// <summary>
        /// Обновление настроения
        /// </summary>
        public void UpdateMood()
        {
            if (Properties.Settings.Default.MoodCount >= 30)
            {
                Properties.Settings.Default.Mood = "Хорошее";
            }
            if (Properties.Settings.Default.MoodCount > 60)
            {
                Properties.Settings.Default.Mood = "Отличное";
            }
            if (Properties.Settings.Default.MoodCount < 30)
            {
                Properties.Settings.Default.Mood = "Плохое";
            }
            if (Properties.Settings.Default.MoodCount == 0)
            {
                TimerTime.Stop();
                youLose.Show();
            }

        }
        /// <summary>
        /// Обновление статуса
        /// </summary>
        public void UpdateStatus()
        {
            if (Properties.Settings.Default.Programming == "Pascal")
            {
                Properties.Settings.Default.Status = "Пользователь";
            }
            if (Properties.Settings.Default.Programming == "Assembler")
            {
                Properties.Settings.Default.Status = "Продвинутый";
            }
            if (Properties.Settings.Default.Programming == "VisualBasic")
            {
                Properties.Settings.Default.Status = "Программист";
            }
            if (Properties.Settings.Default.Programming == "Delphi")
            {
                Properties.Settings.Default.Status = "Хакер";
            }
        }

        SoundPlayer music = new SoundPlayer(Properties.Resources.MusicBack);
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMood formMood = new FormMood();
            formMood.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            MenuWork.Text = Properties.Settings.Default.Work + " / " + Convert.ToString(Properties.Settings.Default.MoneyWorking) + " / день";
            LabelComputer.Text = Properties.Settings.Default.Computer;
            LabelMemory.Text = Properties.Settings.Default.Memory;
            LabelHardDrive.Text = Properties.Settings.Default.HardDrive;
            LabelModem.Text = Properties.Settings.Default.Modem;
            LabelCDROM.Text = Properties.Settings.Default.CDROM;
            LabelSoundBlaster.Text = Properties.Settings.Default.SoundBlaster;
            LabelSystem.Text = Properties.Settings.Default.System;
            LabelAntiVirus.Text = Properties.Settings.Default.AntiVirus;
            LabelProgramming.Text = Properties.Settings.Default.Programming;
            LabelBBS.Text = Properties.Settings.Default.BBS;
            LabelMoneyCount.Text = Convert.ToString(Properties.Settings.Default.MoneyCount);
            LabelStatus.Text = Properties.Settings.Default.Status;
            LabelMood.Text = Properties.Settings.Default.Mood;
            LabelPoints.Text = Convert.ToString(Properties.Settings.Default.Point);
            labelOtherSoft.Text = Convert.ToString(Properties.Settings.Default.Soft);

        }

        private void описаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout AboutProgramm = new FormAbout();
            AboutProgramm.Show();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void музыкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            music.Play();
        }

        private void выключитьМузыкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music.Stop();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document (*.Save) | *.Save| All Files (*.*)|*.*";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;

                try
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileName))
                    {
                        streamWriter.WriteLine(Properties.Settings.Default.Computer);
                        streamWriter.WriteLine(Properties.Settings.Default.Memory);
                        streamWriter.WriteLine(Properties.Settings.Default.HardDrive);
                        streamWriter.WriteLine(Properties.Settings.Default.Modem);
                        streamWriter.WriteLine(Properties.Settings.Default.CDROM);
                        streamWriter.WriteLine(Properties.Settings.Default.SoundBlaster);
                        streamWriter.WriteLine(Properties.Settings.Default.System);
                        streamWriter.WriteLine(Properties.Settings.Default.AntiVirus);
                        streamWriter.WriteLine(Properties.Settings.Default.Programming);
                        streamWriter.WriteLine(Properties.Settings.Default.BBS);
                        streamWriter.WriteLine(Properties.Settings.Default.MoneyCount);
                        streamWriter.WriteLine(Properties.Settings.Default.Status);
                        streamWriter.WriteLine(Properties.Settings.Default.Mood);
                        streamWriter.WriteLine(Properties.Settings.Default.MoodCount);
                        streamWriter.WriteLine(Properties.Settings.Default.MoneyWorking);
                        streamWriter.WriteLine(Properties.Settings.Default.Work);
                        streamWriter.WriteLine(Properties.Settings.Default.Point);
                        streamWriter.WriteLine(Properties.Settings.Default.Soft);
                    }

                    MessageBox.Show("Сохранение завершено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Данные не сохранились\n" + ex.Message);
                }


            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void ComputerUpgrade_Click(object sender, EventArgs e)
        {
            FormComputerWorks formComputerUpgrade = new FormComputerWorks();
            formComputerUpgrade.Show();
        }

        private void Programms_Click(object sender, EventArgs e)
        {
            FormProgrammInstall programmInstall = new FormProgrammInstall();
            programmInstall.Show();
        }

        private void WorkBBS_Click(object sender, EventArgs e)
        {
            FormBBS formBBS = new FormBBS();
            formBBS.Show();
        }

        private void FindWork_Click(object sender, EventArgs e)
        {
            FormWorkFind formWorkFind = new FormWorkFind();
            formWorkFind.Show();
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            i++;
            LabelDate.Text = DateTime.Now.ToShortDateString();
            if (i >= 24)
            {
                i = 0;
            }
            
                if (i == 0 && Properties.Settings.Default.Work == "Дворник")
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount + 10;
                }

                if (i == 0 && Properties.Settings.Default.Work == "Слесарь")
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount + 20;
                }

                if (i == 0 && Properties.Settings.Default.Work == "Программист")
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount + 30;
                }

                if (i == 0 && Properties.Settings.Default.Work == "Сис админ")
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount + 40;
                }

                if (i == 0 && Properties.Settings.Default.Work == "Хакер")
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount + 50;
                }
                if (i == 0)
                {
                    Properties.Settings.Default.Point = Properties.Settings.Default.Point + 3;
                }

                Random random = new Random();
                int Fishing = random.Next(0, 150);

                Random virus = new Random();
                int Virus = virus.Next(0, 300);

                if (Fishing == 1 && Properties.Settings.Default.MoneyCount >= 10 && Properties.Settings.Default.MoneyCount <= 20 )
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 5;
                    MessageBox.Show("Вы попали на фишинговый сайт\nУ вас украли 5$", "Мошенники", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Fishing == 1 && Properties.Settings.Default.MoneyCount > 20 && Properties.Settings.Default.MoneyCount <= 30 )
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 10;
                    MessageBox.Show("Вы попали на фишинговый сайт\nУ вас украли 10$", "Мошенники", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Fishing == 1 && Properties.Settings.Default.MoneyCount > 30 && Properties.Settings.Default.MoneyCount <= 40)
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 15;
                    MessageBox.Show("Вы попали на фишинговый сайт\nУ вас украли 15$", "Мошенники", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Fishing == 1 && Properties.Settings.Default.MoneyCount > 40 )
                {
                    Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 20;
                    MessageBox.Show("Вы попали на фишинговый сайт\nУ вас украли 20$", "Мошенники", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (Virus == 1 && Properties.Settings.Default.HardDrive == "Куплено")
                {
                    Properties.Settings.Default.HardDrive = "Сломан";
                    MessageBox.Show("Червь проник на ваш жёсткий диск\n Починка стоит 15$", "Вирус", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Properties.Settings.Default.HardDrive == "Сломан")
                {
                   RepairHDD.Enabled = true;
                }
            
            TimeLabel.Text = i.ToString("00") + ":00";
            this.updateMainForm();
            this.UpdateMood();
            this.UpdateStatus();
            this.Winner();
            Properties.Settings.Default.MoodCount = Properties.Settings.Default.MoodCount - 1;
            if (Properties.Settings.Default.Soft < 0)
            {
                Properties.Settings.Default.Soft = 0;
            }

            Random rndm = new Random();
            int softupdate = rndm.Next(0, 8);   
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate == 1 && Properties.Settings.Default.AntiVirus == "Нет")
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft + 1;
            }
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate == 2 && Properties.Settings.Default.AntiVirus == "Нет")
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft + 2;
            }
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate == 3 && Properties.Settings.Default.AntiVirus == "Нет")
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft + 3;
            }
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate == 4 && Properties.Settings.Default.AntiVirus == "Нет")
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft + 4;
            }
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate == 1 && Properties.Settings.Default.AntiVirus == "Куплено" && Properties.Settings.Default.Soft > 0)
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft - 1;
            }
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate == 2 && Properties.Settings.Default.AntiVirus == "Куплено" && Properties.Settings.Default.Soft > 1)
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft - 2;
            }
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate == 3 && Properties.Settings.Default.AntiVirus == "Куплено" && Properties.Settings.Default.Soft > 2)
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft - 3;
            }
            if (Properties.Settings.Default.Computer == "Куплено" && softupdate ==4 && Properties.Settings.Default.AntiVirus == "Куплено" && Properties.Settings.Default.Soft > 3)
            {
                Properties.Settings.Default.Soft = Properties.Settings.Default.Soft - 4;
            }
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void Work_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void WorkMoneyCount_Click(object sender, EventArgs e)
        {

        }

        private void MenuWork_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LabelComputer_Click(object sender, EventArgs e)
        {

        }

        private void FormMainMenu_Enter(object sender, EventArgs e)
        {
        }

        private void LabelMood_Click(object sender, EventArgs e)
        {

        }

        private void LabelStatus_Click(object sender, EventArgs e)
        {

        }

        private void загрузитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Document (*.Save) | *.Save| All Files (*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
             
                string fileName = open.FileName;
                try
                {
                    using (StreamReader streamReader = new StreamReader(fileName))
                    {
                        Properties.Settings.Default.Computer = streamReader.ReadLine();
                        Properties.Settings.Default.Memory = streamReader.ReadLine();
                        Properties.Settings.Default.HardDrive = streamReader.ReadLine();
                        Properties.Settings.Default.Modem = streamReader.ReadLine();
                        Properties.Settings.Default.CDROM = streamReader.ReadLine();
                        Properties.Settings.Default.SoundBlaster = streamReader.ReadLine();
                        Properties.Settings.Default.System = streamReader.ReadLine();
                        Properties.Settings.Default.AntiVirus = streamReader.ReadLine();
                        Properties.Settings.Default.Programming = streamReader.ReadLine();
                        Properties.Settings.Default.BBS = streamReader.ReadLine();
                        Properties.Settings.Default.MoneyCount = int.Parse(streamReader.ReadLine());
                        Properties.Settings.Default.Status = streamReader.ReadLine();
                        Properties.Settings.Default.Mood = streamReader.ReadLine();
                        Properties.Settings.Default.MoodCount = int.Parse(streamReader.ReadLine());
                        Properties.Settings.Default.MoneyWorking = int.Parse(streamReader.ReadLine()); ;
                        Properties.Settings.Default.Work = streamReader.ReadLine();
                        Properties.Settings.Default.Point = int.Parse(streamReader.ReadLine());
                        Properties.Settings.Default.Soft = int.Parse(streamReader.ReadLine());
                    }
                    MessageBox.Show("Данные успешно загружены");
                    this.Close();
                    LoadForm = new Thread(OpenForm);
                    LoadForm.Start();
                   
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Данные не загрузились\n" + ex.Message);
                }
            }
        }

        private void labelOtherSoft_Click(object sender, EventArgs e)
        {

        }

        private void RepairHDD_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MoneyCount >= 15)
            {
                Properties.Settings.Default.HardDrive = "Куплено";
                Properties.Settings.Default.MoneyCount = Properties.Settings.Default.MoneyCount - 15;
                RepairHDD.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно денег", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
