﻿namespace PA_JSON_EDITOR.PapaEditor
{
    partial class PapaEditorForm
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
            this.pick_papa_button = new System.Windows.Forms.Button();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pick_papa_button
            // 
            this.pick_papa_button.Location = new System.Drawing.Point(12, 12);
            this.pick_papa_button.Name = "pick_papa_button";
            this.pick_papa_button.Size = new System.Drawing.Size(100, 23);
            this.pick_papa_button.TabIndex = 0;
            this.pick_papa_button.Text = "Pick papa file";
            this.pick_papa_button.UseVisualStyleBackColor = true;
            this.pick_papa_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.open_file_dialog_FileOk);
            // 
            // PapaEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 61);
            this.Controls.Add(this.pick_papa_button);
            this.Name = "PapaEditorForm";
            this.Text = "Papa Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pick_papa_button;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
    }
}