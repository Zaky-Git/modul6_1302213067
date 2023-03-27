using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213067
{
    internal class sayaTubeVideo
    {
        int id;
        string title;
        int playCount;
        public sayaTubeVideo(string title)
        {
            this.title = title;
            int playCount = 0;
            Random rand = new Random();
            this.id = rand.Next(9999, 99999);
        }

        public int getPlayCount()
        {
            return playCount;
        }

        public void increasePlayCount(int count)
        {
            playCount = count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video id " + id + " Judul " +
                title + " diputar sebanyak " + playCount + " kali");
        }
    }
}
