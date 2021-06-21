using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 売上データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            var score = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                var items = line.Split(',');
                var scores = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                score.Add(scores);
            }

            return score;
        }

        //メソッドの概要： 科目別点数を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (Student scores in _score) {
                if (dict.ContainsKey(scores.Subject))
                    // 既にコレクションに店舗が設定されている
                    dict[scores.Subject] += scores.Score;
                else
                    // コレクションへ店舗を登録
                    dict[scores.Subject] = scores.Score;
            }
            return dict;
        }
    }
}
