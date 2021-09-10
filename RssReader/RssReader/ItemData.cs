using System;

namespace RssReader
{
    // 読み込んだ情報を格納する
    internal class ItemData
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime PubDate { get; set; }
        public string Description { get; set; }
    }
}