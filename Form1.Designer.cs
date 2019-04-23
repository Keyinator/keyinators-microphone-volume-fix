namespace Mic_Volume_Fix
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folder = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scalar = new System.Windows.Forms.HScrollBar();
            this.volume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose the \"csgo\" folder";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "C:\\Program Files (x86)\\Steam";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // folder
            // 
            this.folder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.folder.Location = new System.Drawing.Point(218, 85);
            this.folder.Name = "folder";
            this.folder.ReadOnly = true;
            this.folder.Size = new System.Drawing.Size(367, 20);
            this.folder.TabIndex = 0;
            this.folder.Text = "CLICK TO SELECT FOLDER";
            this.folder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.folder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.folder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.folder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.title.Location = new System.Drawing.Point(208, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(385, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Keyinator\'s Microphone-Volume-Fix";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(215, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1)   Find the Steam-folder where Counter Strike: Global Offensive is located in";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(327, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2)   Select the desired volume";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(322, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Volume: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // percent
            // 
            this.percent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percent.AutoSize = true;
            this.percent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.percent.Location = new System.Drawing.Point(387, 143);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(15, 13);
            this.percent.TabIndex = 5;
            this.percent.Text = "%";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(593, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(C) 23.04.2019 Immanuel von Neumann";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(277, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "3)   Click run to have the needed settings changed";
            // 
            // console
            // 
            this.console.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.console.Location = new System.Drawing.Point(50, 238);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(700, 96);
            this.console.TabIndex = 12;
            this.console.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(358, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scalar
            // 
            this.scalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scalar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scalar.LargeChange = 1;
            this.scalar.Location = new System.Drawing.Point(399, 143);
            this.scalar.Name = "scalar";
            this.scalar.Size = new System.Drawing.Size(80, 13);
            this.scalar.TabIndex = 10;
            this.scalar.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // volume
            // 
            this.volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.volume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volume.Location = new System.Drawing.Point(367, 143);
            this.volume.Name = "volume";
            this.volume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.volume.Size = new System.Drawing.Size(20, 13);
            this.volume.TabIndex = 0;
            this.volume.WordWrap = false;
            this.volume.TextChanged += new System.EventHandler(this.volume_TextChanged);
            this.volume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.volume_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.console);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scalar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyinator\'s Microphone-Volume-Fix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox folder;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar scalar;
        private System.Windows.Forms.TextBox volume;
    }
}

