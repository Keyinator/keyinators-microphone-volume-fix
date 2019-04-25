using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mic_Volume_Fix {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) {
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e) {
            volume.Text = scalar.Value.ToString();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                folder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            console.Text = "Running...";
            console.AppendText (System.Environment.NewLine + "Checking filepath...");
            try {
                CheckFilePath();
            } catch (Exception exception) {
                int i = console.TextLength;
                console.AppendText (System.Environment.NewLine + exception.Message);
                console.Select(i, console.TextLength- i);
                console.SelectionColor = Color.Red;
                return;
            }
        }

        void CheckFilePath() {
            if (folder.Text == "CLICK TO SELECT FOLDER") {
                throw new Exception("ERROR: Filepath has not been changed");
            }
            if (!Directory.Exists(folder.Text)) {
                throw new Exception("ERROR: Filepath does not exist");
            }
            if (folder.Text.Split(Path.DirectorySeparatorChar).Last() != "Steam") {
                throw new Exception("ERROR: Filepath does not lead to the directory \"Steam\"");
            }
            String volume = scalar.Value.ToString();
            if (!(scalar.Value == 100)) {
                volume = "0." + scalar.Value;
            }
            String dir = folder.Text + "\\userdata";
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries) {
                String strFile = File.ReadAllText(subdirectory + "\\730\\local\\cfg\\config.cfg");
                int start = strFile.IndexOf("voice_mixer_volume \"", 0)+20;
                int end = strFile.IndexOf("\"", start + 1);

                Color c = console.SelectionColor;
                console.SelectionColor = Color.Green;
                console.AppendText(System.Environment.NewLine + "Changing \"" + strFile.Slice(start, end));
                console.AppendText("\" to \"" + volume + "\"");
                console.SelectionColor = c;
                console.AppendText(" in " + subdirectory + "\\730\\local\\cfg\\config.cfg");

                strFile = strFile.Remove(start,end-start);
                strFile = strFile.Insert(start, volume);
                File.WriteAllText(subdirectory + "\\730\\local\\cfg\\config.cfg", strFile);
            }
        }

        private void volume_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
            else if (Char.IsDigit(e.KeyChar) && int.Parse(volume.Text + e.KeyChar) > 100)
                e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void volume_TextChanged(object sender, EventArgs e) {
            if (double.TryParse(volume.Text, out double _out)) {
                //if (!((int.Parse(volume.Text)) >= 0 && (int.Parse(volume.Text) <= 100)))
                  //  volume.Text = string.Empty;
                //else
                    scalar.Value = int.Parse(volume.Text);
            }
        }
    }
}
public static class Extensions {
    /// <summary>
    /// Get the string slice between the two indexes.
    /// Inclusive for start index, exclusive for end index.
    /// </summary>
    public static string Slice(this string source, int start, int end) {
        if (end < 0) // Keep this for negative end support
        {
            end = source.Length + end;
        }
        int len = end - start;               // Calculate length
        return source.Substring(start, len); // Return Substring of length
    }
}