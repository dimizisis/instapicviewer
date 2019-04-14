using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Instagram_Profile_Photo_Revealer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {

            Boolean successful = run_cmd();

            if (successful) browserBtn.Enabled = true;
            

        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            username.Text = Clipboard.GetText(); // Paste from clipboard
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (!fixedLink.Text.Equals(""))
                Clipboard.SetText(fixedLink.Text); // Copy to clipboard
        }

        private void browserBtn_Click(object sender, EventArgs e)
        {
            Process.Start(fixedLink.Text); // Open fixed link in default browser
        }

        private Boolean run_cmd()
        {
            try
            {
                string fileName = @"script.py";

                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "python.exe";
                Console.Write(username.Text);
                Console.Read();
                start.Arguments = string.Format("{0} {1}", fileName, username.Text);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        fixedLink.Text = result;

                    }
                }
                return true;
            }
            catch { return false; }
            

        }
    }
}
