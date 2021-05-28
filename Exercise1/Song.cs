using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class Song {
        
        public string Title { get; private set; }   // 歌のタイトル
        public string ArtistName { get; private set; }  // アーティスト名
        public int Length { get; private set; } // 演奏時間（秒）


        // コンストラクタ
        public Song(string title, string artistname, int length) {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
        
    }
}
