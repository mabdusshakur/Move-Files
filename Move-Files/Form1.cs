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

namespace Move_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopyPngFiles(string sourcePath, string destinationPath)
        {
            // Validate input paths
            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Source directory does not exist.", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            // Enumerate files recursively
            foreach (string file in Directory.EnumerateFiles(sourcePath, "*.png", SearchOption.AllDirectories))
            {
                string destinationFile = Path.Combine(destinationPath, Path.GetFileName(file));

                // Check if destination file already exists
                if (File.Exists(destinationFile))
                {

                }
                else
                {
                    // Copy the file
                    File.Copy(file, destinationFile);
                }
            }
        }

        private void target_folder_btn_Click(object sender, EventArgs e)
        {
            if (target_folder_dialog.ShowDialog() == DialogResult.OK)
            {
                target_folder_path_tb.Text = target_folder_dialog.SelectedPath.ToString();
            }
        }

        private void destination_folder_btn_Click(object sender, EventArgs e)
        {
            if(destination_folder_dialog.ShowDialog() == DialogResult.OK)
            {
                destination_folder_path_tb.Text = destination_folder_dialog.SelectedPath.ToString();
            }
        }

        private void move_btn_Click(object sender, EventArgs e)
        {
            CopyPngFiles(target_folder_path_tb.Text, destination_folder_path_tb.Text);
        }
    }
}
