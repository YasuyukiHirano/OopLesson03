using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 問題5-1
            //Console.WriteLine("-----5-1-----");
            //Console.Write("文字列(1)を入力してください: ");
            //var str1 = Console.ReadLine();

            //Console.Write("文字列(2)を入力してください: ");
            //var str2 = Console.ReadLine();

            //if (string.Compare(str1,str2,true) == 0)
            //{
            //    Console.WriteLine("入力した文字列は一致しています。");
            //}
            //else
            //{
            //    Console.WriteLine("入力した文字列は一致していません。");
            //}

            //Console.WriteLine("");
            #endregion


            #region 問題5-2
            //Console.WriteLine("-----5-2-----");
            //Console.Write("数字文字列を入力してください: ");
            //var num = Console.ReadLine();
            //int number;

            //if (int.TryParse(num, out number))
            //{
            //    Console.WriteLine("{0:#,#}", number);
            //}
            //else
            //{
            //    Console.WriteLine("数値文字列ではありません");
            //}
            //Console.WriteLine("");
            #endregion



            #region 問題5-3
            //var text = "Jackdaws love my big sphinx of quartz";

            ////5-3-1
            //Console.WriteLine("-----5-3-1-----");
            //int moji = text.Count(s => s == ' ');
            //Console.WriteLine($"空白は{moji}文字です。");
            //Console.WriteLine("");


            ////5-3-2
            //Console.WriteLine("-----5-3-2-----");
            //var replaced = text.Replace("big","small");
            //Console.WriteLine(replaced);
            //Console.WriteLine("");


            ////5-3-3
            //Console.WriteLine("-----5-3-3-----");
            //int count = text.Split(' ').Count();
            //Console.WriteLine($"単語数は{count}文字です。");
            //Console.WriteLine("");


            ////5-3-4
            //Console.WriteLine("-----5-3-4-----");
            //var length = text.Split(' ').Where(s => s.Length <= 4);
            //foreach (var item in length)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("");


            ////5-3-5
            //Console.WriteLine("-----5-3-5-----");
            //var yumi = text.Split(' ').ToArray();
            //var sb = new StringBuilder();
            //foreach (var item in yumi)
            //{
            //    sb.Append(item);
            //    sb.Append(' ');
            //}
            //var texts = sb.ToString();
            //Console.WriteLine(texts);
            //Console.WriteLine("");
            #endregion



            #region 問題5-4
            Console.WriteLine("-----5-4-----");
            var text = "NoveList=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var equal = text.Replace("NoveList=", "作家  : ").Replace("BestWork=", "代表作: ").Replace("Born=", "誕生年: ").Split(';');
            foreach (var item in equal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            #endregion
        }
    }
}
