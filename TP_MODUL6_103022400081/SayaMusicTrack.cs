using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TP_MODUL6_103022400081
{
    internal class SayaMusicTrack
    {
        private int id;
        private string playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title.Length <= 100, "Judul Maksimal 100 Karakter");
            Debug.Assert(title != null, " judul tidak boleh null");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = "0";
        }
        public void IncreasePlayCount(int count)
        {;
            Debug.Assert(count <= 10000000, " Play Count maksimal 10.000.000");

            try
            {
                int current = int.Parse(playCount);
                checked
                {
                    current += count;
                }
                playCount = current.ToString();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi Overflow");
            }    
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
