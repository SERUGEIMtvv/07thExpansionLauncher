using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Resources;

namespace ZeroSeventhExpansionLauncher
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonHigQ1_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigQ1_exe"]);
        private void ButtonHigQ2_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigQ2_exe"]);
        private void ButtonHigQ3_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigQ3_exe"]);
        private void ButtonHigQ4_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigQ4_exe"]);
        private void ButtonHigA1_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigA1_exe"]);
        private void ButtonHigA2_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigA2_exe"]);
        private void ButtonHigA3_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigA3_exe"]);
        private void ButtonHigA4_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigA4_exe"]);
        private void ButtonHigRei_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigRei_exe"]);
        private void ButtonHigHou_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigHou_exe"]);
        private void ButtonHigCon_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["HigCon_exe"]);
        private void ButtonUmiQ_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["UmiQ_exe"]);
        private void ButtonUmiA_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["UmiA_exe"]);
        private void ButtonUmiT_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["UmiT_exe"]);
        private void ButtonUmiH_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["UmiH_exe"]);
        private void ButtonUmiS_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["UmiS_exe"]);
        private void ButtonCic1_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["Cic1_exe"]);
        private void ButtonCic2_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["Cic2_exe"]);
        private void ButtonCic3_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["Cic3_exe"]);
        private void ButtonCic4_Click(object sender, EventArgs e) => Process.Start(ConfigurationManager.AppSettings["Cic4_exe"]);
        private void ButtonQuit_Click(object sender, EventArgs e) => Process.GetCurrentProcess().Kill();
        private void ButtonEng_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("en"));
            }
            foreach (Control c in tabControl.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("en"));
            }
            foreach (Control c in tabPageHig.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("en"));
            }
            foreach (Control c in tabPageUmi.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("en"));
            }
            foreach (Control c in tabPageCic.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("en"));
            }
            pictureBoxHig.BackgroundImage = Properties.Resources.hig_logo;
            pictureBoxUmi.BackgroundImage = Properties.Resources.umi_logo;
            pictureBoxCic.BackgroundImage = Properties.Resources.cic_logo;
        }
        private void ButtonJa_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("ja-JP"));
            }
            foreach (Control c in tabControl.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("ja-JP"));
            }
            foreach (Control c in tabPageHig.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("ja-JP"));
            }
            foreach (Control c in tabPageUmi.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("ja-JP"));
            }
            foreach (Control c in tabPageCic.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
                resources.ApplyResources(c, c.Name, new CultureInfo("ja-JP"));
            }
            pictureBoxHig.BackgroundImage = Properties.Resources.hig_logo_ja;
            pictureBoxUmi.BackgroundImage = Properties.Resources.umi_logo_ja;
            pictureBoxCic.BackgroundImage = Properties.Resources.cic_logo_ja;
        }

        private void PictureBoxHig_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBoxUmi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBoxCic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
