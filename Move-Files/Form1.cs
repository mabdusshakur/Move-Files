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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Move_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetTotalFilesCount(string path)
        {
            return Directory.EnumerateFiles(path, "*" + file_type_cb.Text, SearchOption.AllDirectories).Count();
        }

        private void CopyPngFiles(string sourcePath, string destinationPath, System.Windows.Forms.ProgressBar progressBar)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = GetTotalFilesCount(sourcePath); // Calculate total files in advance

            int copiedFiles = 0;

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
            foreach (string file in Directory.EnumerateFiles(sourcePath, "*"+ file_type_cb.Text, SearchOption.AllDirectories))
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
                    copiedFiles++;
                    progressBar.Value = copiedFiles;
                }
            }
        }

        private void PopulateComboBoxWithFileTypes(string sourcePath)
        {
            if (!Directory.Exists(sourcePath))
            {
                return; // Handle non-existent source path
            }

            // Enumerate files recursively
            var fileInfos = Directory.EnumerateFiles(sourcePath, "*", SearchOption.AllDirectories);

            // Extract and group file extensions
            var fileTypes = fileInfos
                .Select(fi => Path.GetExtension(fi).ToLowerInvariant()) // Convert to lowercase for case-insensitivity
                .Where(ext => !string.IsNullOrEmpty(ext)) // Exclude empty extensions
                .GroupBy(ext => ext)
                .Select(group => group.Key);

            // Add file types to combo box
            file_type_cb.Items.Clear();
            file_type_cb.Items.AddRange(fileTypes.ToArray());
        }

        private void target_folder_btn_Click(object sender, EventArgs e)
        {
            if (target_folder_dialog.ShowDialog() == DialogResult.OK)
            {
                target_folder_path_tb.Text = target_folder_dialog.SelectedPath.ToString();
            }
            PopulateComboBoxWithFileTypes(target_folder_path_tb.Text);
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
            CopyPngFiles(target_folder_path_tb.Text, destination_folder_path_tb.Text, progress_bar);
        }
    }
}
