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
using System.Threading;
using System.Diagnostics;

namespace Sensor_data_coverter
{
    public partial class Form1 : Form
    {
        /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */

        /* public class point
         {
            public double X;
            public double Y;
            public string Z;          
         }*/


        //List<point> points_list = new List<point>();

        int left_offset = 0;
        int top_offset = 0;

        const float limit = -90;

        double m_factor=0.005;

        string input_path;
        Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }


        private void Pick_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            input_path = openFileDialog1.FileName;
        }

        private void Pick_output_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }


        public double find_lowest_value(string path)
        {
            StreamReader sr = new StreamReader(path);
            double lowest=0;

            int X_coord = 0;
            int Y_coord = 0;
            string input_line = "";

            for (int i = 0; i < top_offset; i++)
            {
                sr.ReadLine();
            }

            while ((input_line = sr.ReadLine()) != null)
            {

                input_line = input_line.Replace(" ", string.Empty);

                string[] points = input_line.Split(',');

                for (int i = left_offset; i < points.Length; i++)
                {
                    
                    if (Convert.ToDouble(points[i].Replace(".", ",")) < limit)
                    {

                    }
                    else
                    {
                      double temp = Convert.ToDouble(points[i].Replace(".", ","));
                        if(temp<lowest)
                        {
                            lowest = temp;
                        }
                    }

                    X_coord++;
                }

                X_coord = 0;
                Y_coord++;

            }

            return lowest;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ticks_label.Text = "00:00";
            miliseconds_label.Text = "00:00";
            seconds_label.Text = "00:00";
            minutes_label.Text = "00:00";
            stopwatch.Start();

            string output_path = saveFileDialog1.FileName;
            StreamReader stream_reader = new StreamReader(input_path);
            StreamWriter stream_writer = new StreamWriter(output_path);

            int X_coord=0;
            int Y_coord=0;
            string input_line = "";

            double lowest = find_lowest_value(input_path);

            for(int i = 0 ; i<top_offset ; i++ )
            {
                stream_reader.ReadLine();
            }

            while ((input_line = stream_reader.ReadLine())!=null)
            {
                 input_line = input_line.Replace(" ", string.Empty);
                 string[] points = input_line.Split(',');

                 for (int i =  left_offset; i < points.Length ; i++)
                 {
                    if(Convert.ToDouble(points[i].Replace(".", ","))<limit)
                    {  }
                    else
                    {
                        stream_writer.WriteLine((X_coord * m_factor).ToString().Replace(",",".") + "," + (Y_coord * m_factor).ToString().Replace(",", ".") + "," + ((Convert.ToDouble(points[i].Replace(".", ","))-lowest).ToString().Replace(",",".")));
                        Console.WriteLine(X_coord.ToString()+ Y_coord.ToString()+ points[i]);
                    }
                    X_coord++;
                 }
                X_coord = 0;
                Y_coord++;
            }
            input_path = "";
            output_path = "";
            X_coord=0;
            Y_coord=0;

            stream_writer.Flush();
            stream_reader.Close();
            stream_writer.Close();

            stopwatch.Stop();
            ticks_label.Text = lowest.ToString();
            miliseconds_label.Text = stopwatch.Elapsed.Milliseconds.ToString();
            seconds_label.Text = stopwatch.Elapsed.Seconds.ToString();
            minutes_label.Text = stopwatch.Elapsed.Minutes.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void change_offsets_button_Click(object sender, EventArgs e)
        {
            try
            {
                top_offset = Convert.ToInt16(top_offset_box.Text);
            }
            catch
            {
                top_offset = 0;
            }

            try
            {
                left_offset = Convert.ToInt16(left_offset_box.Text);
            }
            catch
            {
                left_offset = 0;
            }

            try
            {
                m_factor = Convert.ToDouble(multiplication_box.Text.Replace(".", ","));
            }
            catch
            {
                m_factor = 1;
            } 
            
        }

        private void top_offset_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void left_offset_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void multiplication_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */
    }
}

