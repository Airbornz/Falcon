using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falcon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblVersion.Text = "Version: " + GetType().Assembly.GetName().Version.ToString();

            String os = new ComputerInfo().OSFullName;

            int size = InstallForm.getSoftwareList().Count;
            if (size == 0) { 
                btnInstall.Enabled = false;
            }

            if (!File.Exists("ccleaner.exe")) { 
                btnCCleaner.Enabled = false;
            }

            if (!File.Exists("strip.cmd")) { 
                btnCCleaner.Enabled = false;
            }

            if (!File.Exists("wifi.cmd")) { 
                btnWifi.Enabled = false;
            }

            if (!File.Exists("crp.cmd")) { 
                btnRestore.Enabled = false;
            }

            if (!File.Exists("arp.cmd")) { 
                btnAutoRestore.Enabled = false;
            }

            if (!File.Exists("passwordRem.cmd")) {
                btnPassword.Enabled = false;
            }

            if (!File.Exists("windows/windows11.exe") || !os.Contains("Windows 10")) { 
                btnWindows.Enabled = false;
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            InstallForm frm = new InstallForm();
            frm.Show();
        }

        private void btnCCleaner_Click(object sender, EventArgs e)
        {
            Process.Start("ccleaner.exe");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserMoverForm frm = new UserMoverForm();
            frm.Show();
        }

        private void btnStrip_Click(object sender, EventArgs e)
        {
            Process.Start("strip.cmd");
        }

        private void btnWifi_Click(object sender, EventArgs e)
        {
            Process.Start("wifi.cmd");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Process.Start("crp.cmd");
        }

        private void btnAutoRestore_Click(object sender, EventArgs e)
        {
            Process.Start("arp.cmd");
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please verify owner of PC before performing password removal.", "Falcon Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("passwordRem.cmd");
        }

        private void btnWindows_Click(object sender, EventArgs e)
        {
            Process.Start("windows/windows11.exe");
        }
    }
}
