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
using Big_file_reader;

namespace Big_file_reader
{
    /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */
    public struct Streams_Container
    {
        public Stream base_stream;
        public StreamReader stream_reader;
        public StreamWriter stream_writer;
        public string input_file_path;
    }

    public partial class Form1 : Form
    {
        Streams_Container stream_container;

        int amount;
        bool stream_exists=false;
        string input_filename;

        public Form1()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Handler for button, Opens open file dialog
        /// </summary>
        private void Pick_file_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// Handler open file dialog, creates stream and it's reader
        /// </summary>
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            
            stream_container = new Streams_Container();

            stream_container.stream_reader = Stream_controler.Create_Reader(openFileDialog1.FileName);
            stream_container.base_stream = Stream_controler.Get_Base_Stream(stream_container.stream_reader);

            stream_container.input_file_path = openFileDialog1.FileName;

            stream_exists = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Handler for button, Shows current line
        /// </summary>
        private void Show_line_Click_1(object sender, EventArgs e)
        {
            if(stream_exists==true)
            {
                Console.WriteLine(stream_container.stream_reader.ReadLine());
            }
            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Handler for button, Moves stream to start
        /// </summary>
        private void Move_to_start_Click_1(object sender, EventArgs e)
        {
            if (stream_exists == true)
            {
                Stream_controler.Move_Stream(stream_container, (int)MoveMode.Start);
            }
        }

        /// <summary>
        /// Handler for button, Moves stream to end -1 line
        /// </summary>
        private void Move_to_end_Click(object sender, EventArgs e)
        {
                if (stream_exists == true)
                {
                    Stream_controler.Move_Stream(stream_container, (int)MoveMode.End);
                }
        }

        /// <summary>
        /// Handler for button, Shows current line
        /// </summary>
        private void Move_by_amount_Click(object sender, EventArgs e)
        {
            if (stream_exists == true)
            {
                try
                {
                    amount = Convert.ToInt16(textBox_amount.Text);
                    Stream_controler.Move_Stream(stream_container, (int)MoveMode.Amount, amount);
                }
                catch
                {

                }  
                  
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        /// <summary>
        /// Event handler for input
        /// </summary>
        private void textBox_amount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void create_log_button_Click(object sender, EventArgs e)
        {
            if(stream_exists==true)
            {
                saveFileDialog1.ShowDialog();
            }   
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string save_path;
            save_path = saveFileDialog1.FileName;

            if(save_path != null)
            {
                stream_container.stream_writer = new StreamWriter(save_path); 
                Stream_controler.Generate_log(stream_container, input_filename);

            }   

        }
    }
    /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */
}
