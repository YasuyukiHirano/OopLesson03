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
            #region
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
        }
    }
}
