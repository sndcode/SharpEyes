using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
//Additional Imports

namespace SharpEyes
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            double intensity = (slider1.Value - slider1.Minimum) / (double)(slider1.Maximum - slider1.Minimum);
            this.lbl_Intensity.Text = intensity.ToString("N2");

            Program.Method5(intensity, out double red, out double green, out double blue);

            var rrrr = (float)Math.Round(red / 255, 4);
            var gggg = (float)Math.Round(green / 255, 4);
            var bbbb = (float)Math.Round(blue / 255, 4);

            txtEditor.Text = string.Format("{0:N3}\t{1:N3}\t{2:N3}", rrrr, gggg, bbbb);
            label3.Text = string.Format("{0}K", slider1.Value);
        }
        Dictionary<int, int> _todLookup; // time of day lookup
        static string _defaultSettings = @"00:00	2700
        06:00	4500
        18:30	4000
        20:00	2700";
        private void timer1_Tick(object sender, EventArgs e)
        {
            slider1.Value = _todLookup[(int)DateTime.Now.TimeOfDay.TotalSeconds];
        }
        public static string pcUsername()
        {
            string s = System.Environment.UserName;
            return s;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registryKey.SetValue("SE", Application.ExecutablePath);
            _todLookup = Program.BuildTimeOfDayLookup(_defaultSettings);
            richTextBox1.Text += "\n" + DateTime.Now.TimeOfDay.TotalSeconds;
            string s_settingspath = "C:\\users\\" + pcUsername() + "\\AppData\\Local\\settings.ini";
            if (!File.Exists(s_settingspath))
            {
                var myFile = File.Create(s_settingspath);
                myFile.Close();
            }
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            var vals = txtEditor.Text.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (vals.Length != 3) return;

            try
            {
                Program.SetGamma(
                    Convert.ToDouble(vals[0]),
                    Convert.ToDouble(vals[1]),
                    Convert.ToDouble(vals[2])
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                    Program.SetGamma(
                    Convert.ToDouble(1),
                    Convert.ToDouble(1),
                    Convert.ToDouble(1)
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
