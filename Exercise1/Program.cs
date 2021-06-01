using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            // 2.1.3
            var songs = new Song[] {
                new Song("ARASHI","嵐",243),
                new Song("EverybodyGo","Kis-My-Ft2",293),
                new Song("SexyZone","SexyZone",276),
                new Song("UltraMusicPower","Hey!Say!JUMP",231),
                new Song("シンデレラガール","King＆Prince",273),
            };
            PrintSongs(songs);
        }

        // 2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:m\:ss}",song.Title,song.ArtistName,TimeSpan.FromSeconds( song.Length));
            }
        }

    }
}
