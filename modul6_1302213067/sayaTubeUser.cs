using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modul6_1302213067
{
    internal class sayaTubeUser
    {
        private int id;
        private List<sayaTubeVideo> uploadVideos;
        public string Username;

        public sayaTubeUser(string username)
        {
            Contract.Requires(Username.Length < 100);
            Contract.Requires(Username != null);
            this.Username = username;
            Random random = new Random();
            this.id = random.Next(9999, 99999);
            uploadVideos = new List<sayaTubeVideo>();
        }



        public int getTotalVideoPlayCount()
        {
            int tot = 0;
            for (int i = 0; i < uploadVideos.Count; i++)
            {
                tot = tot + uploadVideos[i].getPlayCount();
            }
            return tot;
        }

        public void AddVideo(sayaTubeVideo video)
        {
            Contract.Requires(video != null);
            Contract.Requires(video.getPlayCount() < int.MaxValue);
            

            uploadVideos.Add(video);

        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + Username);
            for (int i = 0; i < uploadVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadVideos[i].getTitle());
            }
        }
    }
}
