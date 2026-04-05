using System;
using System.Collections.Generic;
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
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = null;
        }
        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
