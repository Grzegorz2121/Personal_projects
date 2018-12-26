using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BIGG_DATA
{
    /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string file_path;

        long X=100000;
        long Y=10000000;

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            file_path = saveFileDialog1.FileName;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter stream_writer = new StreamWriter(file_path);

            string line = "";
            string output = "";

            for (int i = 0; i < X; i++)
            {
                line = line + ("5,");
            }

            line = line.Remove(line.Length - 1);

            for (int j = 0; j < Y;j++)
            {
                stream_writer.WriteLine(line);
            }

            stream_writer.Flush();
            stream_writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                X = Convert.ToInt32(textBox1.Text);
                Y = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                X = 5;
                Y = 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */
}
