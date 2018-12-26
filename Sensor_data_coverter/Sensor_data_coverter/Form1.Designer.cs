namespace Sensor_data_coverter
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
            this.Pick_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Pick_output = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.miliseconds_label = new System.Windows.Forms.Label();
            this.ticks_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seconds_label = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.minutes_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.change_offsets_button = new System.Windows.Forms.Button();
            this.left_offset_box = new System.Windows.Forms.TextBox();
            this.top_offset_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.multiplication_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pick_file
            // 
            this.Pick_file.Location = new System.Drawing.Point(12, 12);
            this.Pick_file.Name = "Pick_file";
            this.Pick_file.Size = new System.Drawing.Size(130, 52);
            this.Pick_file.TabIndex = 0;
            this.Pick_file.Text = "Pick input file";
            this.Pick_file.UseVisualStyleBackColor = true;
            this.Pick_file.Click += new System.EventHandler(this.Pick_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Pick_output
            // 
            this.Pick_output.Location = new System.Drawing.Point(12, 87);
            this.Pick_output.Name = "Pick_output";
            this.Pick_output.Size = new System.Drawing.Size(130, 52);
            this.Pick_output.TabIndex = 3;
            this.Pick_output.Text = "Pick output";
            this.Pick_output.UseVisualStyleBackColor = true;
            this.Pick_output.Click += new System.EventHandler(this.Pick_output_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Program made by ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grzegorz Machura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grzegorz2121";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Poland, Dolnoslaskie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "I LO w Jaworze";
            // 
            // miliseconds_label
            // 
            this.miliseconds_label.AutoSize = true;
            this.miliseconds_label.Location = new System.Drawing.Point(427, 38);
            this.miliseconds_label.Name = "miliseconds_label";
            this.miliseconds_label.Size = new System.Drawing.Size(34, 13);
            this.miliseconds_label.TabIndex = 9;
            this.miliseconds_label.Text = "00:00";
            // 
            // ticks_label
            // 
            this.ticks_label.AutoSize = true;
            this.ticks_label.Location = new System.Drawing.Point(302, 93);
            this.ticks_label.Name = "ticks_label";
            this.ticks_label.Size = new System.Drawing.Size(34, 13);
            this.ticks_label.TabIndex = 10;
            this.ticks_label.Text = "00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Miliseconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ticks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Seconds";
            // 
            // seconds_label
            // 
            this.seconds_label.AutoSize = true;
            this.seconds_label.Location = new System.Drawing.Point(362, 38);
            this.seconds_label.Name = "seconds_label";
            this.seconds_label.Size = new System.Drawing.Size(34, 13);
            this.seconds_label.TabIndex = 13;
            this.seconds_label.Text = "00:00";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(302, 61);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(44, 13);
            this.label60.TabIndex = 16;
            this.label60.Text = "Minutes";
            // 
            // minutes_label
            // 
            this.minutes_label.AutoSize = true;
            this.minutes_label.Location = new System.Drawing.Point(303, 38);
            this.minutes_label.Name = "minutes_label";
            this.minutes_label.Size = new System.Drawing.Size(34, 13);
            this.minutes_label.TabIndex = 15;
            this.minutes_label.Text = "00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 147);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // change_offsets_button
            // 
            this.change_offsets_button.Location = new System.Drawing.Point(318, 179);
            this.change_offsets_button.Name = "change_offsets_button";
            this.change_offsets_button.Size = new System.Drawing.Size(126, 47);
            this.change_offsets_button.TabIndex = 19;
            this.change_offsets_button.Text = "Change offsets";
            this.change_offsets_button.UseVisualStyleBackColor = true;
            this.change_offsets_button.Click += new System.EventHandler(this.change_offsets_button_Click);
            // 
            // left_offset_box
            // 
            this.left_offset_box.Location = new System.Drawing.Point(376, 289);
            this.left_offset_box.MaxLength = 12;
            this.left_offset_box.Name = "left_offset_box";
            this.left_offset_box.Size = new System.Drawing.Size(100, 20);
            this.left_offset_box.TabIndex = 20;
            this.left_offset_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.left_offset_box_KeyPress);
            // 
            // top_offset_box
            // 
            this.top_offset_box.Location = new System.Drawing.Point(376, 250);
            this.top_offset_box.MaxLength = 12;
            this.top_offset_box.Name = "top_offset_box";
            this.top_offset_box.Size = new System.Drawing.Size(100, 20);
            this.top_offset_box.TabIndex = 21;
            this.top_offset_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.top_offset_box_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Left offset";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Top offset";
            // 
            // multiplication_box
            // 
            this.multiplication_box.Location = new System.Drawing.Point(172, 250);
            this.multiplication_box.MaxLength = 12;
            this.multiplication_box.Name = "multiplication_box";
            this.multiplication_box.Size = new System.Drawing.Size(100, 20);
            this.multiplication_box.TabIndex = 24;
            this.multiplication_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.multiplication_box_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Multiplication";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "64bit, No buffer, Offset options, Disregards values below -90";
            this.label12.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 333);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.multiplication_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.top_offset_box);
            this.Controls.Add(this.left_offset_box);
            this.Controls.Add(this.change_offsets_button);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.minutes_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.seconds_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ticks_label);
            this.Controls.Add(this.miliseconds_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pick_output);
            this.Controls.Add(this.Pick_file);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sensor data converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pick_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Pick_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label miliseconds_label;
        private System.Windows.Forms.Label ticks_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label seconds_label;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label minutes_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button change_offsets_button;
        private System.Windows.Forms.TextBox left_offset_box;
        private System.Windows.Forms.TextBox top_offset_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox multiplication_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

