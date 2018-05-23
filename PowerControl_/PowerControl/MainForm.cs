using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButShutDown_Click(object sender, EventArgs e)
        {
            Stat.ShutDown();
        }

        private void ButRestart_Click(object sender, EventArgs e)
        {
            Stat.Restart();
        }

        private void ButSignOut_Click(object sender, EventArgs e)
        {
            Stat.SignOut();
        }

        private void ButHiber_Click(object sender, EventArgs e)
        {
            Stat.Hiber();
        }

        private void ButLock_Click(object sender, EventArgs e)
        {
            Stat.Lock();
        }

        private void ButSleep_Click(object sender, EventArgs e)
        {
            Stat.Sleep();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void openAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
