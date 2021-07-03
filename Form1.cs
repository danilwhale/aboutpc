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

namespace AboutPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
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
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // узнаём, и отображаем всё об нашем "любимом" виндовс
            var regNTProd = (string)Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion")?.GetValue("productName");
            WindowsVersion.Text = regNTProd;
            // проверяем, является ли наша виндовс, 64 битной
            bool is64Bit = Environment.Is64BitOperatingSystem;
            // бла-бла меняется лого виндовс в зависимости от версии
            if (regNTProd.StartsWith("Windows 10"))
                logoBox.BackgroundImage = Properties.Resources.Windows10logo;
            if (regNTProd.StartsWith("Windows 8.1"))
                logoBox.BackgroundImage = Properties.Resources.Windows8Logo;
            if (regNTProd.StartsWith("Windows 7"))
                logoBox.BackgroundImage = Properties.Resources.Windows7Logo;
            // добавляем надпись если наш виндовс 64 битный
            if (is64Bit == true)
                WindowsVersion.Text = regNTProd + ", 64 бита";
            // иначе 32 бита
            else if (is64Bit == false)
                WindowsVersion.Text = regNTProd + ", 32 бита";
            // узнаём информацию об пользователе
            string username = Environment.UserName;
            string pcname = Environment.MachineName;
            UserName.Text = username;
            PCName.Text = pcname;
            // всё о нашей характеристике "игрового пк"
            ManagementObject mo;
            mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
            ushort i = (ushort)mo["Architecture"];
            string CPU = GetHardwareInfo("Win32_Processor", "Name")[0];
            string GPU = GetHardwareInfo("Win32_VideoController", "Name")[0];
            ulong mem = GetTotalMemoryInBytes();
            string RAM = (mem / (1024 * 1024) + " Mб").ToString();
            Processor.Text = CPU;
            Videocard.Text = GPU;
            RAMCapacity.Text = RAM;
            switch (i)
            {
                case 0:
                    Processor.Text = CPU + ", 32 бит";
                    break;
                case 9:
                    Processor.Text = CPU + ", 64 бит";
                    break;
            }
        }
        Settings s = new Settings();
        private void button1_Click(object sender, EventArgs e)
        {
            s.ShowDialog();
        }
    }
}
