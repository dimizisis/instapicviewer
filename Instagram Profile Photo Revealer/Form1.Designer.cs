namespace Instagram_Profile_Photo_Revealer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.username = new System.Windows.Forms.TextBox();
            this.fixedLink = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.browserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username.Location = new System.Drawing.Point(33, 12);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(180, 20);
            this.username.TabIndex = 0;
            this.username.Text = "Enter username...";
            // 
            // fixedLink
            // 
            this.fixedLink.Location = new System.Drawing.Point(33, 99);
            this.fixedLink.Name = "fixedLink";
            this.fixedLink.Size = new System.Drawing.Size(180, 20);
            this.fixedLink.TabIndex = 1;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(33, 51);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(104, 32);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate Link";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pasteBtn.Location = new System.Drawing.Point(219, 12);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(61, 20);
            this.pasteBtn.TabIndex = 3;
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.copyBtn.Location = new System.Drawing.Point(219, 99);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(61, 20);
            this.copyBtn.TabIndex = 4;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // browserBtn
            // 
            this.browserBtn.Enabled = false;
            this.browserBtn.Location = new System.Drawing.Point(152, 51);
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.Size = new System.Drawing.Size(104, 32);
            this.browserBtn.TabIndex = 5;
            this.browserBtn.Text = "Open in Browser";
            this.browserBtn.UseVisualStyleBackColor = true;
            this.browserBtn.Click += new System.EventHandler(this.browserBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 131);
            this.Controls.Add(this.browserBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.fixedLink);
            this.Controls.Add(this.username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 170);
            this.MinimumSize = new System.Drawing.Size(308, 170);
            this.Name = "Main";
            this.Text = "Instagram Profile Photo Revealer 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox fixedLink;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button browserBtn;
    }
}

