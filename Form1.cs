using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System.IO;

namespace AboutPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(app.Default.Localization);
            InitializeComponent();
        }
        static ulong GetTotalMemoryInBytes()
        {
            return new ComputerInfo().TotalPhysicalMemory;
        }
        static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }
        string ram;
        string cpu;
        string gpu;
        bool isCPU64;
        string usrnm;
        string pcnam;
        bool isSys64;
        string winver;
        string winedit;
        string windispvr;
        string winbuild;
        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementObject mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");

            ulong mem = GetTotalMemoryInBytes(); // количество озу
            ushort i = (ushort)mo["Architecture"]; // архитектура цп

            string CPU = GetHardwareInfo("Win32_Processor", "Name")[0]; // получаем информацию о цп
            string GPU = GetHardwareInfo("Win32_VideoController", "Name")[0]; // получаем информацию о гп
            string RAM = (mem / (1024 * 1024) + " MБ").ToString(); // считаем размер озу в мб

            string username = Environment.UserName; // имя пользователя
            string pcname = Environment.MachineName; // имя пк

            bool is64Bit = Environment.Is64BitOperatingSystem; // есть ли наша система 64-битная

            ram = RAM;
            cpu = CPU;
            gpu = GPU;
            usrnm = username;
            pcnam = pcname;
            isSys64 = is64Bit;

            // получаем имя windows в реестре
            var regNT = Registry.LocalMachine.OpenSubKey(
                    "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"
                );

            string prodName = (string)regNT?.GetValue("ProductName");
            string prodEdit = (string)regNT?.GetValue("EditionID");
            string prodDispVer = (string)regNT?.GetValue("DisplayName");
            double prodBuild = Convert.ToDouble(regNT?.GetValue("CurrentBuild"));

            winver = prodName;
            winbuild = prodBuild.ToString();
            winedit = prodEdit;
            windispvr = prodDispVer;

            #region Информация Windows
            if (prodName.StartsWith("Windows 10"))
            {
                if (prodBuild >= 22000)
                {
                    WindowsVersion.Text = "Windows 11 " + prodDispVer;
                    LogoBox.Image = Resources.Windows11Logo;
                }
                WindowsVersion.Text = "Windows 10 " + prodDispVer;
                LogoBox.Image = Resources.Windows10logo;
            }
            else if (prodName.StartsWith("Windows 11"))
            {
                WindowsVersion.Text = "Windows 11 " + prodDispVer;
                LogoBox.Image = Resources.Windows11Logo;
            }
            else if (prodName.StartsWith("Windows 8") || prodName.StartsWith("Windows 8.1"))
            {
                WindowsVersion.Text = prodName.Substring(0, 9);
                LogoBox.Image = Resources.Windows8Logo;
            }
            else if (prodName.StartsWith("Windows 7"))
            {
                WindowsVersion.Text = "Windows 7";
                LogoBox.Image = Resources.Windows7Logo;
            }

            if (is64Bit)
                WindowsArch.Text = "x64";
            else
                WindowsArch.Text = "x32";

            WindowsEdition.Text = prodEdit;
            WindowsBuild.Text = prodBuild.ToString();
            #endregion
            #region Информация пользователя
            Username.Text = username;
            PCName.Text = pcname;
            #endregion
            #region Информация компьютера
            CPUs.Text = CPU;
            GPUs.Text = GPU;
            RAMs.Text = RAM;
            if (i == 0)
            {
                CPUs.Text += " (x32)";
                isCPU64 = false;
            }
            else
            {
                CPUs.Text += " (x64)";
                isCPU64 = true;
            }

            #endregion

            


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            panel1.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox1.Location);
        }

        private void sdsdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] info = {
                "WINDOWS INFORMATION",
                "Version:         " + winver,
                "Edition:         " + winedit,
                "Display version: " + windispvr,
                "Build:           " + winbuild,
                "   USER INFORMATION",
                "Username:        " + usrnm,
                "Computer name:   " + pcnam,
                "COMPUTER INFORMATION",
                "RAM:             " + ram,
                "CPU:             " + cpu,
                "GPU:             " + gpu
            };
            File.WriteAllLines(saveFileDialog1.FileName, info);
            MessageBox.Show("Информация была сохранена.\nПуть: " + saveFileDialog1.FileName);
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.About about = new Forms.About();
            about.ShowDialog();
        }
    }
}
