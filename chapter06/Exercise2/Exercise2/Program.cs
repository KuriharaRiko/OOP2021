﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };
            #region
            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
            #endregion
        }
        private static void Exercise2_1(List<Book> books) {
            var book = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
            if (book != null) {
                Console.WriteLine("{0} {1}", book.Price, book.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine(books.Count(x => x.Title.Contains("C#")) + "冊");
        }

        private static void Exercise2_3(List<Book> books) {
            var average = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages);
            Console.WriteLine(average);
        }    

        private static void Exercise2_4(List<Book> books) {
            var first = books.FirstOrDefault(x => x.Price >= 4000);
            if (first != null) {
                Console.WriteLine(first.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            var pages = books.Where(x => x.Price < 4000).Max(x => x.Pages);
            Console.WriteLine(pages);
        }

        private static void Exercise2_6(List<Book> books) {
            var book = books.Where(x => x.Pages >= 400).OrderByDescending(x => x.Price);
            foreach (var item in book) {
                Console.WriteLine("{0} {1}", item.Title, item.Price);
            }        
        }

        private static void Exercise2_7(List<Book> books) {
            var book = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            foreach (var item in book) {
                Console.WriteLine(item.Title);
            }           
        }
    }
}
