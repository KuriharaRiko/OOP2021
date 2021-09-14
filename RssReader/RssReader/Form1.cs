﻿using System;
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

        IEnumerable<ItemData> items = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRasTitle(tbUrl.Text);
           
            //リンク先のList[lbTitles.SelectedIndex];
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
                items = xdoc.Root.Descendants("item").Select(x => new　ItemData
                {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description")
                });
                foreach (var item in items)
                {
                    lbTitles.Items.Add(item.Title);   
                }
            }
        }

        // リストボックスクリックイベントハンドラ
        private void lbTitles_Click(object sender, EventArgs e)
        {
            string link = (items.ToArray())[lbTitles.SelectedIndex].Link;   // 配列へ変換して[]でアクセス
            //wbBrowser.Url = new Uri(link);

            lbDescription.Text = "概要\n";
            lbDescription.Text += (items.ToArray())[lbTitles.SelectedIndex].Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいFormへ表示するリンク先を渡す処理を追加
            var wbForm = new Form2();
            wbForm.Show();
        }
    }
}
