using System;
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

            if (!imageLink.Text.Contains("https:")) MessageBox.Show("Please enter a valid instagram photo link (Right Click On Image -> Open in New Window -> Copy Link)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                string link = imageLink.Text; // Original image link

                string startLink = "https://scontent-lga3-1.cdninstagram.com/"; // How fixed link will start!

                string fLink = link.Replace("/vp", ""); // Retrieve last 113 characters of original link (the ones we need to place to our fixed)!

                fixedLink.Text = startLink + fLink.Replace("s150x150", "s1080x1080"); // Start with fixed instagram server and place the ID's with new dimensions (1080x1080)!

                browserBtn.Enabled = true; // Open in browser can now be clicked

                fixedLink.SelectAll(); // Select all by double clicking on fixed link text

            }

        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            imageLink.Text = Clipboard.GetText(); // Paste from clipboard
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (!fixedLink.Text.Equals(""))
                Clipboard.SetText(fixedLink.Text); // Copy to clipboard
        }

        private void browserBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fixedLink.Text); // Open fixed link in default browser
        }

    }
}
