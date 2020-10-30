using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //var flowerDict = new Dictionary<string, int>()
            //{
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            //flowerDict["violet"] = 600;
            //flowerDict.Add("chulip", 650);
            #endregion

            #region
            //var employeeDict = new Dictionary<int, Employee>
            //{
            //    { 100,new Employee(100,"清水遼久")},
            //    { 112,new Employee(112,"芹沢洋和")},
            //    { 125,new Employee(125,"岩瀬奈央子")},
            //};

            //Console.WriteLine($"{employeeDict.Sum(emp => emp.Value.Id)}");

            //var employees = employeeDict.Where(emp => emp.Value.Id % 2 == 0);
            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{item.Value.Name}");
            //}


            //var employee = new List<Employee>()
            //{
            //    new Employee(100,"清水遼久"),
            //    new Employee(112,"芹沢洋和"),
            //    new Employee(125,"岩瀬奈央子"),
            //    new Employee(143,"山田太郎"),
            //    new Employee(148,"池田次郎"),
            //    new Employee(152,"高田三郎"),
            //    new Employee(155,"石川幸也"),
            //    new Employee(161,"中沢信也"),
            //};

            ////Idが偶数のみディクショナリに変換する
            //var employeeDict = employee.Where(emp => emp.Id % 2 == 0).ToDictionary(emp => emp.Id);

            //foreach (KeyValuePair<int, Employee> item in employeeDict)
            //{
            //    Console.WriteLine($"{item.Value.Id} {item.Value.Name}");
            //}
            #endregion

            #region
            //var lines = File.ReadAllLines("sample.txt");
            //var we = new WordsExtractor(lines);
            //foreach (var word in we.Extract())
            //{
            //    Console.WriteLine(word);
            //}

            ////var dict = new Dictionary<MonthDay, string>
            ////{
            ////    {new MonthDay(3,5),"珊瑚の日" },
            ////    {new MonthDay(8,4),"箸の日" },
            ////    {new MonthDay(10,3),"登山の日" },
            ////};

            ////var md = new MonthDay(8, 4);
            ////var s = dict[md];
            ////Console.WriteLine(s);
            //DuplicateKeySample();
            #endregion

            #region 辞書登録プログラム

            //Console.WriteLine("********************");
            //Console.WriteLine("*辞書登録プログラム*");
            //Console.WriteLine("********************");
            //Console.WriteLine();

            //// ディクショナリの初期化
            //var dict = new Dictionary<string, List<string>>() { };            


            //while(true)
            //{
            //    Console.WriteLine("1.登録 2.内容を表示 3.終了");
            //    Console.Write(">");
            //    var choice = int.Parse(Console.ReadLine());
            //    Console.WriteLine();

            //    switch (choice)
            //    {
            //        case 1:
            //                // ディクショナリに追加
            //                Console.Write("KEYを入力: ");
            //                var key = Console.ReadLine();
            //                Console.Write("VALUEを入力: ");
            //                var value = Console.ReadLine();
            //                if (dict.ContainsKey(key))
            //                {
            //                    dict[key].Add(value);
            //                }
            //                else
            //                {
            //                    dict[key] = new List<string> { value };
            //                }
            //                Console.WriteLine("登録しました!");
            //            Console.WriteLine("");
            //        break;

            //        case 2:
            //            // ディクショナリの内容を列挙
            //            foreach (var item in dict)
            //            {
            //                foreach (var term in item.Value)
            //                {
            //                    Console.WriteLine("{0} : {1}", item.Key, term);
            //                }
            //            }
            //            Console.WriteLine();
            //        break;

            //        case 3:
            //            break;

            //        default :
            //            Console.WriteLine("1or2or3を選択してください。");
            //            Console.WriteLine();
            //            break;
            //    }
            //    if (choice == 3)
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region 演習問題7-1
            //var text = "Cozy lummox gives smart squid who asks for job pen";

            ////問題7-1
            //Console.WriteLine("*****7-1-1*****");
            //Exercise1_1(text);

            ////問題7-2
            //Console.WriteLine("*****7-1-2*****");
            //Exercise1_2(text);
            #endregion

            #region 演習問題7-2

            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //問題7-2-3
            //Countプロパティを呼び出して数を出力させる
            var count = abbrs.count;
            Console.WriteLine(abbrs.count);
            Console.WriteLine();

            //問題7-2-3
            //Removeプロパティを呼び出して数を出力させる
            if (abbrs.Remove("NPT"))
            {
                Console.WriteLine("削除成功");
            }
            else
            {
                Console.WriteLine("削除失敗");
            }
            Console.WriteLine();


            //問題7-2-4            
            foreach (var item in abbrs.Where(x => x.Key.Length == 3))
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }


            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();

            #endregion
        }

        #region
        //public static void DuplicateKeySample()
        //{
        //    // ディクショナリの初期化
        //    var dict = new Dictionary<string, List<string>>() {
        //       { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
        //       { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
        //    };

        //    // ディクショナリに追加
        //    var key = "EC";
        //    var value = "電子商取引";
        //    if (dict.ContainsKey(key))
        //    {
        //        dict[key].Add(value);
        //    }
        //    else
        //    {
        //        dict[key] = new List<string> { value };
        //    }

        //    // ディクショナリの内容を列挙
        //    foreach (var item in dict)
        //    {
        //        foreach (var term in item.Value)
        //        {
        //            Console.WriteLine("{0} : {1}", item.Key, term);
        //        }
        //    }
        //}
        #endregion

        #region 演習問題7-1
        //static void Exercise1_1(string text)
        //{
        //    var dict = new Dictionary<Char, int>();
        //    //foreachで一文字ずつ取り出す
        //    foreach (var item in text)
        //    {
        //        //文字列を大文字に変換
        //        var key = Char.ToUpper(item);
        //        //半角アルファベットか調べる
        //        if ('A' <= key && key <= 'Z')
        //        {
        //            //keyに存在するか
        //            if (dict.ContainsKey(key))
        //            {
        //                //存在する
        //                dict[key]++;
        //            }
        //            else
        //            {
        //                //存在しない
        //                dict[key] = 1;
        //            }
        //        }
        //    }
        //    //集計が完了したらテキストの出力例を参考にして出力
        //    foreach (var item in dict.OrderBy(x => x.Key))
        //    {
        //        Console.WriteLine("{0}:{1}",item.Key,item.Value);
        //    }
        //    Console.WriteLine();
        //}


        //static void Exercise1_2(string text)
        //{
        //    var dict = new SortedDictionary<Char,int>();
        //    foreach (var item in text)
        //    {
        //        //大文字変換
        //        var key = Char.ToUpper(item);
        //        //半角アルファベットかどうか調べる
        //        if ('A' <= key && key <= 'Z')
        //        {
        //            //keyに存在するか
        //            if (dict.ContainsKey(key))
        //            {
        //                //存在する
        //                dict[key]++;
        //            }
        //            else
        //            {
        //                //存在しない
        //                dict[key] = 1;
        //            }
        //        }
        //    }
        //    //集計が完了したらテキストの出力例を参考にして出力
        //    foreach (var item in dict)
        //    {
        //        Console.WriteLine("{0}:{1}",item.Key,item.Value);
        //    }
        //}
        #endregion
    }
}
