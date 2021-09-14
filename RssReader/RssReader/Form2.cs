using System;
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
        string url = "";

        public Form2(string url)
        {
            InitializeComponent();
            this.url = url;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            wbBrowser.Url = new Uri(url);
        }

        // ページの読み込みが完了すると呼ばれる
        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btBack.Enabled = wbBrowser.CanGoBack;
            btFoward.Enabled = wbBrowser.CanGoForward;
            
        }

        private void btFoward_Click(object sender, EventArgs e)
        {
            wbBrowser.GoForward();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            wbBrowser.GoBack();
        }
    }
}
