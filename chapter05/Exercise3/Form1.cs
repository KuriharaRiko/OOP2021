using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        // フォームがロードされるタイミングで1回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStrData.Text = "Novelist = 谷崎潤一郎; BestWork = 春琴抄; Born = 1886";
        }

        private void button5_3_1_Click(object sender, EventArgs e) {
            TextBoxSpaceCount.Text = inputStrText.Text.Count(c => c == ' ').ToString();
        }

        private void button5_3_2_Click(object sender, EventArgs e) {
            TextBoxWordChange.Text = inputStrText.Text.Replace("big", "small").ToString();
        }

        private void button5_3_3_Click(object sender, EventArgs e) {
            TextBoxWordCount.Text = inputStrText.Text.Split(' ').Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            var Words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in Words) {
                TextBoxCount.Text += word + " ";
            }
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            if (array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                tbStringBuilder.Text = sb.ToString();
            }
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            // Novelist = 谷崎潤一郎
            // BestWork = 春琴抄
            // Born = 1886
            foreach (var pair in inputStrData.Text.Split(';')) {
                var array = pair.Split('=');
                outputStrData.Text += ToJapanese(array[0]) + ":" + array[1] + Environment.NewLine;  // 改行
            }
        }
        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
