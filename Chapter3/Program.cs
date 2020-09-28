using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        ////デリゲートの宣言(int型の引数を受け取ってbool値を返すメソッド)
        //public delegate bool Judgement(int value);

        static void Main(string[] args)
        {

            #region 3-1 演習問題

            //var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            ////3-1-1
            //var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            //if (exists)
            //{
            //    Console.WriteLine("値は存在しています。");
            //}
            //else
            //{
            //    Console.WriteLine("値は存在していません。");
            //}
            //Console.WriteLine("");


            ////3-1-2
            //numbers.ForEach(s => Console.WriteLine(s / 2.0));
            //Console.WriteLine("");


            ////3-1-3
            //var num = numbers.Where(s => s >= 50);

            //foreach (var item in num)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("");


            ////3-1-4
            //*List<int> nums = */numbers.Select(a => a * 2).ToList().ForEach(Console.WriteLine);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 3-2 演習問題
            //3-2 演習問題

            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong kong",
            };

            //3-2-1
            Console.Write("都市名を入力してください(空行で終了): ");

            do
            {
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                var num = names.FindIndex(s => s == name);
                Console.WriteLine(num);

            } while (true);
            
            Console.WriteLine("");


            //3-2-2
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
            Console.WriteLine("");


            //3-2-3
            names.Where(s => s.Contains("o")).ToList().ForEach(s => Console.WriteLine(s));
            Console.WriteLine("");


            //3-2-4
            var nums = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region 練習
            //var names = new List<string>
            //{
            //    "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong kong",
            //};

            //var query = names.Where(s => s.Length <= 5).ToList();   //ToListを書くとこの行で即時実行される

            //foreach (string item in query)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------");

            //names[0] = "Osaka";
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}


            //list.ConvertAll(s => s.ToUpper()).ForEach(s => Console.WriteLine(s));

            //list.ForEach(s => Console.WriteLine(s));

            //var name = list.FindAll(s => s.Length <= 5);

            //foreach (var n in name)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
        }
    }
}
