using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRasTitle(tbUrl.Text);

            リンク先のList[lbTitles.SelectedIndex];
        }

        List<string> link = new List<string>();

        // 指定したURL先からXMLデータを取得しtitle要素を取得し、リストボックスへセットする
        private void setRasTitle(string uri)
        {
            
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");

                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    lbTitles.Items.Add(node.Value);
                    
                }
                link.Add(uri);
            }
            
        }   
    }
}
