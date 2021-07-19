using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]
    class CarReport {
        public DateTime Date { get; set; }  // 日付
        public string Auter { get; set; }   // 記録者
        public Makergroup Maker { get; set; }   // メーカー
        public string CarName { get; set; } // 車名
        public string Report { get; set; }  // レポート
        public Image Picture { get; set; }  // 画像

        // メーカー
        public enum Makergroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他,
        }
        // データ更新
        public void UpDate(DateTime date,string auter, Makergroup maker, string carName, string report, Image picture) {
            this.Date = date;
            this.Auter = auter;
            this.Maker = maker;
            this.CarName = carName;
            this.Report = report;
            this.Picture = picture;
        }
    }

    
    
}
