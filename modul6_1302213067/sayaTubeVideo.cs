using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213067
{
    internal class sayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public sayaTubeVideo(string title)
        {
            Contract.Requires(title.Length < 200);
            Contract.Requires(title != null);
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

            Contract.Requires(count >= 0);
            Contract.Requires(count < 25000000);
            try
            {
                checked
                {
         
                    playCount = count;
                }

                } catch(OverflowException) {
                      Console.WriteLine("Overflow");
            }

        }

        public string getTitle()
        {
            return title; 
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video id " + id + " Judul " +
                title + " diputar sebanyak " + playCount + " kali");
        }
    }
}



