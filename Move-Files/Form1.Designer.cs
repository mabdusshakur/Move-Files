namespace Move_Files
{
    partial class Form1
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
            this.target_folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.target_folder_path_tb = new System.Windows.Forms.TextBox();
            this.target_folder_btn = new System.Windows.Forms.Button();
            this.destination_folder_btn = new System.Windows.Forms.Button();
            this.destination_folder_path_tb = new System.Windows.Forms.TextBox();
            this.destination_folder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.move_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // target_folder_path_tb
            // 
            this.target_folder_path_tb.Location = new System.Drawing.Point(12, 12);
            this.target_folder_path_tb.Name = "target_folder_path_tb";
            this.target_folder_path_tb.Size = new System.Drawing.Size(395, 20);
            this.target_folder_path_tb.TabIndex = 0;
            // 
            // target_folder_btn
            // 
            this.target_folder_btn.Location = new System.Drawing.Point(413, 12);
            this.target_folder_btn.Name = "target_folder_btn";
            this.target_folder_btn.Size = new System.Drawing.Size(75, 23);
            this.target_folder_btn.TabIndex = 1;
            this.target_folder_btn.Text = "Target";
            this.target_folder_btn.UseVisualStyleBackColor = true;
            this.target_folder_btn.Click += new System.EventHandler(this.target_folder_btn_Click);
            // 
            // destination_folder_btn
            // 
            this.destination_folder_btn.Location = new System.Drawing.Point(413, 35);
            this.destination_folder_btn.Name = "destination_folder_btn";
            this.destination_folder_btn.Size = new System.Drawing.Size(75, 23);
            this.destination_folder_btn.TabIndex = 3;
            this.destination_folder_btn.Text = "Destination";
            this.destination_folder_btn.UseVisualStyleBackColor = true;
            this.destination_folder_btn.Click += new System.EventHandler(this.destination_folder_btn_Click);
            // 
            // destination_folder_path_tb
            // 
            this.destination_folder_path_tb.Location = new System.Drawing.Point(12, 37);
            this.destination_folder_path_tb.Name = "destination_folder_path_tb";
            this.destination_folder_path_tb.Size = new System.Drawing.Size(395, 20);
            this.destination_folder_path_tb.TabIndex = 2;
            // 
            // move_btn
            // 
            this.move_btn.Location = new System.Drawing.Point(12, 63);
            this.move_btn.Name = "move_btn";
            this.move_btn.Size = new System.Drawing.Size(79, 41);
            this.move_btn.TabIndex = 4;
            this.move_btn.Text = "Move";
            this.move_btn.UseVisualStyleBackColor = true;
            this.move_btn.Click += new System.EventHandler(this.move_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 115);
            this.Controls.Add(this.move_btn);
            this.Controls.Add(this.destination_folder_btn);
            this.Controls.Add(this.destination_folder_path_tb);
            this.Controls.Add(this.target_folder_btn);
            this.Controls.Add(this.target_folder_path_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Move Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog target_folder_dialog;
        private System.Windows.Forms.TextBox target_folder_path_tb;
        private System.Windows.Forms.Button target_folder_btn;
        private System.Windows.Forms.Button destination_folder_btn;
        private System.Windows.Forms.TextBox destination_folder_path_tb;
        private System.Windows.Forms.FolderBrowserDialog destination_folder_dialog;
        private System.Windows.Forms.Button move_btn;
    }
}

