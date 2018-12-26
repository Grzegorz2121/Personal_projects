using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Big_file_reader;

namespace Big_file_reader
{
    /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */

    public enum MoveMode { Start, End, Amount };

    /*public struct Streams_Container
    {
        public Stream base_stream;
        public StreamReader stream_reader;
        public StreamWriter stream_writer;
    }*/

    static class Stream_controler
    {

        public static StreamReader Create_Reader(string input_path)
        {
            if(input_path!=null)
            {
                StreamReader stream_reader = new StreamReader(input_path);
                return stream_reader;
            }
            else
            {
                return null;
            }

        }

        public static Stream Get_Base_Stream(StreamReader stream_reader)
        {
            if(stream_reader != null)
            {
                Stream base_stream = stream_reader.BaseStream;
                return base_stream;
            }
            else
            {
                return null;
            }

        }

/*
        /// <summary>
        /// Iterates through whole file and counts number of lines in it (Resets stream to origin)
        /// </summary>
       public static int Get_line_lenght(Streams_Container s_container)
       {
            int lenght = 0;

            s_container = Move_Stream(s_container, (int)MoveMode.Start);

            while(s_container.stream_reader.ReadLine()!=null)
            {
                lenght++;
            }

            return lenght;
       }
       */

        public static void Generate_log(Streams_Container sc, string filename)
        {
            StreamWriter sw = sc.stream_writer;

            string line;

            long length = new System.IO.FileInfo((sc.input_file_path)).Length;

            sw.WriteLine("Big Data reader log");
            sw.WriteLine("Filename: " + filename);
            sw.WriteLine();
            sw.WriteLine(length);
            sw.WriteLine();
            sw.WriteLine("First 20 lines: ");
            sw.WriteLine();
            Stream_controler.Move_Stream(sc, (int)MoveMode.Start);
            for(int i=0;i<20;i++)
            {
                sw.WriteLine(sc.stream_reader.ReadLine());
            }
            sw.WriteLine();
            sw.WriteLine("Last 20 lines: ");
            sw.WriteLine();
            Stream_controler.Move_Stream(sc, (int)MoveMode.End);
            for (int i = 0; i < 20; i++)
            {
                line = sc.stream_reader.ReadLine();
                if(line==null)
                {
                    break;
                }
                sw.WriteLine(line);
            }
            sw.WriteLine();
            sw.WriteLine("End of log");

            sw.Flush();
            sw.Close();
        }

        public static Streams_Container Move_Stream(Streams_Container s_container, int OperationType, int amount = 0)
        {
            

            switch (OperationType)
            {
                case (int)(MoveMode.Start):
                    s_container.base_stream.Seek(0, SeekOrigin.Begin);
                    s_container.stream_reader.DiscardBufferedData();
                break;
                    
                case (int)(MoveMode.End):
                    long lenght = 0;
                    lenght = s_container.base_stream.Length;
                    s_container.base_stream.Seek(lenght-100, SeekOrigin.Begin);
                    s_container.stream_reader.DiscardBufferedData();
                    break;

                case (int)(MoveMode.Amount):
                    s_container.base_stream.Seek(amount, SeekOrigin.Current);
                    s_container.stream_reader.DiscardBufferedData();
                    break;
            }

            return s_container;
        }
    }
    /* CODE made by Grzegorz Machura (Grzegorz2121, Poland, Dolnyśląsk, I LO w Jaworze) */
}
