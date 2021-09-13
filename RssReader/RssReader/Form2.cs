﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form2 : Form
    {
        Uri url;

        // コンストラクタ
        public Form2(string url)
        {
            InitializeComponent();
            this.url = new Uri(url);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            wbBrowser.Url = url;
        }
    }
}