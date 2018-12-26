namespace Big_file_reader
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Pick_file = new System.Windows.Forms.Button();
            this.Show_line = new System.Windows.Forms.Button();
            this.Move_to_end = new System.Windows.Forms.Button();
            this.Move_to_start = new System.Windows.Forms.Button();
            this.Move_by_amount = new System.Windows.Forms.Button();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.create_log_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_1);
            // 
            // Pick_file
            // 
            this.Pick_file.Location = new System.Drawing.Point(12, 15);
            this.Pick_file.Name = "Pick_file";
            this.Pick_file.Size = new System.Drawing.Size(106, 44);
            this.Pick_file.TabIndex = 0;
            this.Pick_file.Text = "Pick file";
            this.Pick_file.UseVisualStyleBackColor = true;
            this.Pick_file.Click += new System.EventHandler(this.Pick_file_Click_1);
            // 
            // Show_line
            // 
            this.Show_line.Location = new System.Drawing.Point(12, 65);
            this.Show_line.Name = "Show_line";
            this.Show_line.Size = new System.Drawing.Size(106, 44);
            this.Show_line.TabIndex = 1;
            this.Show_line.Text = "Show line";
            this.Show_line.UseVisualStyleBackColor = true;
            this.Show_line.Click += new System.EventHandler(this.Show_line_Click_1);
            // 
            // Move_to_end
            // 
            this.Move_to_end.Location = new System.Drawing.Point(161, 49);
            this.Move_to_end.Name = "Move_to_end";
            this.Move_to_end.Size = new System.Drawing.Size(106, 31);
            this.Move_to_end.TabIndex = 2;
            this.Move_to_end.Text = "Move to end - 100";
            this.Move_to_end.UseVisualStyleBackColor = true;
            this.Move_to_end.Click += new System.EventHandler(this.Move_to_end_Click);
            // 
            // Move_to_start
            // 
            this.Move_to_start.Location = new System.Drawing.Point(161, 12);
            this.Move_to_start.Name = "Move_to_start";
            this.Move_to_start.Size = new System.Drawing.Size(106, 31);
            this.Move_to_start.TabIndex = 3;
            this.Move_to_start.Text = "Move to start";
            this.Move_to_start.UseVisualStyleBackColor = true;
            this.Move_to_start.Click += new System.EventHandler(this.Move_to_start_Click_1);
            // 
            // Move_by_amount
            // 
            this.Move_by_amount.Location = new System.Drawing.Point(161, 86);
            this.Move_by_amount.Name = "Move_by_amount";
            this.Move_by_amount.Size = new System.Drawing.Size(106, 31);
            this.Move_by_amount.TabIndex = 4;
            this.Move_by_amount.Text = "Move by amount";
            this.Move_by_amount.UseVisualStyleBackColor = true;
            this.Move_by_amount.Click += new System.EventHandler(this.Move_by_amount_Click);
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(161, 130);
            this.textBox_amount.MaxLength = 12;
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(106, 20);
            this.textBox_amount.TabIndex = 5;
            this.textBox_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_amount_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount of characters to move";
            // 
            // create_log_button
            // 
            this.create_log_button.Location = new System.Drawing.Point(12, 120);
            this.create_log_button.Name = "create_log_button";
            this.create_log_button.Size = new System.Drawing.Size(106, 44);
            this.create_log_button.TabIndex = 7;
            this.create_log_button.Text = "Create Log";
            this.create_log_button.UseVisualStyleBackColor = true;
            this.create_log_button.Click += new System.EventHandler(this.create_log_button_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Application made by Grzegorz Machura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "(Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 239);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.create_log_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.Move_by_amount);
            this.Controls.Add(this.Move_to_start);
            this.Controls.Add(this.Move_to_end);
            this.Controls.Add(this.Show_line);
            this.Controls.Add(this.Pick_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Data Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pick_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Show_line;
        private System.Windows.Forms.Button Move_by_amount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Change_amount;
        private System.Windows.Forms.Button Move_to_start;
        private System.Windows.Forms.Button Move_to_end;
        private System.Windows.Forms.Button Create_log;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_log_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

