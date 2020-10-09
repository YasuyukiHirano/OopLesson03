using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  練習1
            //var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4,};
            //Console.WriteLine($"平均値: {numbers.Average()}");
            //Console.WriteLine($"合計値: {numbers.Sum()}");            
            //Console.WriteLine($"最小値: {numbers.Where(x => x>= 0).Min()}");            
            //Console.WriteLine($"最大値: {numbers.Max()}");

            //bool exists = numbers.Any(n => n % 7 == 0);

            //var results = numbers.Where(n => n > 0).Take(3);
            //foreach (var item in results)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //var books = Books.GetBooks();
            //Console.WriteLine($"本の平均価格: {books.Average(x => x.Price)}");
            //Console.WriteLine($"本の合計価格: {books.Sum(x => x.Price)}");
            //Console.WriteLine($"本のページが最大: {books.Max(x => x.Pages)}");
            //Console.WriteLine($"本の価格が高価な本: {books.Max(x => x.Price)}");
            //Console.WriteLine($"タイトルに[物語]がある冊数: {books.Count(x => x.Title.Contains("物語"))}");
            //Console.WriteLine();

            ////600ページを超える書籍があるか？(Anyメソッド)
            ////bool exist = books.Any(n => n.Pages > 600);
            ////Console.WriteLine(exist);
            //Console.WriteLine("600ページを超える書籍は");
            //Console.WriteLine(books.Any(x => x.Pages > 600) ? "ある" : "ない");
            //Console.WriteLine();

            ////すべてが200ページ以上の書籍か？(Allメソッド)
            ////bool all = books.All(n => n.Pages >= 200);
            ////Console.WriteLine(all);
            //Console.WriteLine("すべてが200ページ以上の書籍か");
            //Console.WriteLine(books.Any(x => x.Pages >= 200) ? "はい" : "いいえ");
            //Console.WriteLine();

            ////400ページを超える本は何冊目か？(FirstOrDefaultメソッド)
            ////var fod = books.FirstOrDefault(x => x.Pages > 400);
            ////int i;
            ////for (i = 0; i < books.Count; i++)
            ////{
            ////    if (books[i].Title.Contains(fod.Title))
            ////    {
            ////        break;
            ////    }
            ////}
            ////Console.WriteLine($"400ページを超える本は{i + 1}冊目です。");

            //var fod = books.FindIndex(x => x.Pages > 400);
            //Console.WriteLine($"400ページを超える本は{fod + 1}冊目です。");

            ////本の値段が400円以上のものを3冊表示
            //var num = books.Where(x => x.Price >= 400).Take(3);
            //foreach (var item in num)
            //{
            //    Console.WriteLine(item.Title + " ");
            //}
            #endregion

            #region 練習2
            ////整数の例
            //var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };

            ////var strings = numbers.Select(n => n.ToString("0000")).ToArray();
            ////foreach (var item in strings)
            ////{
            ////    Console.Write(item + " ");
            ////}

            //numbers.Distinct().Select(n => n.ToString("0000")).ToList().ForEach(s => Console.Write(s + " "));
            //Console.WriteLine("");

            ////並べ替え
            //var sortedNumbers = numbers.Distinct().OrderBy(n => n);
            //foreach (var nums in sortedNumbers)
            //{
            //    Console.Write(nums + " ");
            //}


            //// 文字列
            //var words = new List<string> { "Microsoft", "Apple", "Google", "Oracle", "Facebook", };

            //var lower = words.Select(name => name.ToLower()).ToArray();

            ////オブジェクトの例
            //var books = Books.GetBooks();

            ////本のタイトルリスト
            //var titles = books.Select(name => name.Title);

            //foreach (var title in titles)
            //{
            //    Console.WriteLine(title + " ");
            //}
            //Console.WriteLine();


            ////ページ数の多い順に並び替え(又は金額の高い順)
            //var sortedPages = books.OrderByDescending(x => x.Pages);
            //Console.Write("ページ数の多い順は");
            //foreach (var item in sortedPages)
            //{
            //    Console.WriteLine(item.Title + " " + item.Pages);
            //}
            //Console.WriteLine("");

            //var sortedPrice = books.OrderByDescending(x => x.Price);
            //Console.Write("金額の高い順は");
            //foreach (var item in sortedPrice)
            //{
            //    Console.WriteLine(item.Title + " " + item.Price);
            //}
            //Console.WriteLine();
            #endregion

            #region 演習問題6-1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            #region  6-1-1
            Console.WriteLine("-----6-1-1-----");
            Console.WriteLine("最大値は" + numbers.Max(x => x) + "です。");
            Console.WriteLine("");
            #endregion
            

            #region 6-1-2
            Console.WriteLine("-----6-1-2-----");
            var num2 = numbers.Skip(9).Take(2) ;
            foreach (var item in num2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            #endregion


            #region 6-1-3
            Console.WriteLine("-----6-1-3-----");
            var num3 = numbers.Select(x => x.ToString());
            foreach (var item in num3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            #endregion


            #region 6-1-4
            Console.WriteLine("-----6-1-4-----");
            var num4 = numbers.OrderBy(x => x).Take(3);
            foreach (var item in num4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            #endregion


            #region 6-1-5
            Console.WriteLine("-----6-1-5-----");
            var num5 = numbers.Distinct().Count(x => x >= 10);
            Console.WriteLine(num5);
            #endregion

            #endregion         
        }
    }
}
