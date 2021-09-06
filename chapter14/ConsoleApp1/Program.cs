using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {
        Dictionary<string, int> AreaDic = new Dictionary<string, int>()
        {
            {"前橋",4210 },
            {"みなかみ",4220 },
            {"宇都宮",4110 },
            {"水戸",4010 },
            {"さいたま",4310 }
        };

        // コードを保存する
        List<int> cityCode = new List<int>();

        static void Main(string[] args)
        {
            new Program();
        }

        // コンストラクタ
        public Program()
        {
            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine();    // 改行
            Console.WriteLine("地域コードを入力");
            int num = 1;
            foreach (KeyValuePair<string, int> pair in AreaDic)
            {
                Console.WriteLine("{0}:{1}", num++, pair.Key);
                cityCode.Add(pair.Value);   // コードをリストへ保存
            }

            Console.WriteLine("9:その他（直接入力）");
            Console.WriteLine();    // 改行

            Console.Write(">");
            // 文字列として入力した数字を取り込む
            var selectArea = Console.ReadLine();
            int pos = int.Parse(selectArea);

            int code;
            if (pos != 9)
            {
                code = cityCode[pos - 1];
            }
            else
            {
                // その他の場合
                Console.Write("都市コードを入力：");
                code = int.Parse(Console.ReadLine());
            }

            var results = GetWeatherReportFromYahoo(code);
            
            foreach (var s in results)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine(); // 入力待ち
        }

        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}
