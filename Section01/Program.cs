using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);


            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine();

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine();

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine();

            // 3.2.4
            Exercise2_4(names);


            // �o�����l�p���
            Excercise2_5(names);
        }

        
        // 3.1
        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);

            if (exist)
                Console.WriteLine("���݂��Ă��܂�");
            else
                Console.WriteLine("���݂��Ă��܂���");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            foreach (var n in numbers.Where(n => n >= 50)) {
                Console.WriteLine(n);
            }
            // numbers.Where(n => n >= 50).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise1_4(List<int> numbers) {
            List<int> list = numbers.Select(n => n * 2).ToList();
            foreach (var num in list) {
                Console.WriteLine(num);
            }
        }


        // 3.2
        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("�s�s������́F");
            var line = Console.ReadLine();  // ���̓f�[�^��荞��
            int index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);            
        }

        private static void Exercise2_3(List<string> names) {
            var selected = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in selected) {
                Console.WriteLine(name);
            }
        }
        private static void Exercise2_4(List<string> names) {
            var selected = names.Where(s => s.StartsWith('B')).Select(s => s.Length);
            foreach (var length in selected) {
                Console.WriteLine(length);
            }           
        }


        // �o�����l�p���
        private static void Excercise2_5(List<string> names) {
            int count = 0;
            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));   // IsLower�F���������ǂ����̃`�F�b�N
            }
            Console.WriteLine(count);
        }
    }
}