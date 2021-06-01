using SalesCalculator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    // 売上集計クラス
    class SalesCounter {
        
        private List<Sale> _sales;

        // コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        // 売上データを読み込み、Saleオブジェクトのリストを返す
        private static List<Sale> ReadSales(string filePath) {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                var items = line.Split(',');
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        //  店舗別売上を求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    // 既にコレクションに店舗が設定されている
                    dict[sale.ShopName] += sale.Amount;
                else
                    // コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }

        // 商品カテゴリ別売上を求める
        public IDictionary<string, int> GetPerCategorySales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory)) 
                    // 既にコレクションに商品カテゴリが設定されている
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    // コレクションへ商品カテゴリを登録
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }        
    }
}

