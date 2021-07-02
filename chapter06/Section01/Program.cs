using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages) + "ページ");
            Console.WriteLine("最も高価な本は" + books.Max(x => x.Price) + "円");
            Console.WriteLine("最も価格の安い本は" + books.Min(x => x.Price) + "円");

            // 500円以上の本は何冊か
            Console.WriteLine("500円以上の本は" + books.Count(x => x.Price >= 500) +"冊");
            Console.WriteLine();

            // タイトルに物語が含まれている本は何冊か
            Console.WriteLine("タイトルに物語が含まれる本は"+ books.Count(x => x.Title.Contains("物語"))+"冊");
            // タイトルに物語が含まれている本の一覧
            var bookData = books.Where(x => x.Title.Contains("物語")).Take(2);
            foreach (var book in bookData) {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine();

            // 高額書籍ベスト3
            var bookBest = books.OrderByDescending(x => x.Price).Take(3);
            foreach (var item in bookBest) {
                Console.WriteLine(item.Title + " " + item.Price);
            }
            Console.WriteLine();

            var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
