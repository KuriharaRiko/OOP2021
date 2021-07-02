using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            #region テスト用ドライバ
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);           
            #endregion
        }


        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine("最大値は" + numbers.Max(x => x));
        }

        private static void Exercise1_2(int[] numbers) {
            var num = numbers.ElementAt(9);
            Console.WriteLine(num);
        }

        private static void Exercise1_3(int[] numbers) {
            var strs = numbers.Select(x => x.ToString());
            foreach (var s in strs) {
                Console.WriteLine(s);
            }           
        }

        private static void Exercise1_4(int[] numbers) {
            foreach (var n in numbers.OrderBy(x => x).Take(3)) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var count = numbers.Distinct().Count(x => x > 10);
            Console.WriteLine(count);
        }      
    }
}
