using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherApp
{
    class Program
    {
        Dictionary<string, int> AreaDic = new Dictionary<string, int>()
        {
            {"前橋",4210 },
            {"みなかみ",4220 },
            {"宇都宮",4110 },
            {"水戸",4010 },
        };

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
            }

            Console.WriteLine("9:その他（直接入力）");
            Console.WriteLine();    // 改行

            Console.Write(">");
            // 文字列として入力した数字を取り込む
            var selectArea = Console.ReadLine();

            var results = GetWeatherReportFromYahoo(4210);
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
