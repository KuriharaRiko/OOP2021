using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args) {
            var file = "Sample.xml";

            Exercise1_1(file);
            Console.WriteLine("------");

            Exercise1_2(file);
            Console.WriteLine("------");

            Exercise1_3(file);
            Console.WriteLine("------");

            Exercise1_4(file);
            Console.WriteLine("------");
        }

        
        
        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new
                             {
                                 Name = x.Element("name").Value,
                                 Teammembers = x.Element("teammenbers").Value
                             });
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                            .Select(x => new
                            {
                                Firstplayed = x.Element("firstplayed").Value,
                                Name = x.Element("name").Attribute("kanji").Value
                            }).OrderBy(x => int.Parse(x.Firstplayed)); ;
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Firstplayed);
            }

        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                  .Select(x => new
                                  {
                                      Name = x.Element("name").Value,
                                      Teammembers = x.Element("teammembers").Value
                                  })
                                  .OrderByDescending(x => int.Parse(x.Teammembers))
                                  .First();
            Console.WriteLine("{0}", sports.Name);
        }

        private static void Exercise1_4(string file)
        {
            var newfile = "sports.xml";

            var element = new XElement("ballSports",
                            new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                            new XElement("teammember", "11"),
                            new XElement("firstplayed", "1873")
                            );
            var xdoc = XDocument.Load(newfile);
            xdoc.Root.Add(element);

            // これ以降は確認用のコード
            foreach (var xsports in xdoc.Root.Elements())
            {
                var xname = xsports.Element("name");
                var teammember = xsports.Element("teammember");
                Console.WriteLine("{0}{1}", xname.Value, teammember.Value);
            }

        }
    }
}
