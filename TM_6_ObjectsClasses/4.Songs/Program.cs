using System;
using System.Collections.Generic;
using System.Linq;
namespace _4.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());

            List<Song> songsList = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songsList.Add(song);
            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (var song in songsList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                // use LINQ to filter the collection
                List<Song> filteredSongs = songsList.Where(s => s.TypeList == typeList).ToList();
                foreach (var song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
                //  foreach (var song in songsList)
                // {
                //    if (song.TypeList == typeList)
                //   {
                //       Console.WriteLine(song.Name);
                //   }
                //  }
            }
            
        }
    }
}
