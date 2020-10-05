using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            //演習問題4-2

            #region 4-2-1
            var ym = new YearMonth[]
            {
                new YearMonth(1990,4),
                new YearMonth(1999,12),
                new YearMonth(2000,8),
                new YearMonth(2099,3),
                new YearMonth(2100,1)
            };            
            #endregion



            #region 4-2-2(呼び出し)
            Exercise2_2(ym);
            Console.WriteLine("--------\n");
            #endregion



            #region 4-2-3(呼び出し)
            //Console.WriteLine(FindFirst21C(ym));
            //Console.WriteLine("--------\n");
            #endregion



            #region 4-2-4(呼び出し)
            Exercise2_4(ym);
            Console.WriteLine("--------\n");
            #endregion



            #region 4-2-5(呼び出し)
            Exercise2_5(ym);
            #endregion
        }

        #region 4-2-2 Exercise2_2メソッド
        private static void Exercise2_2(YearMonth[] ym)
        {
            foreach (var item in ym)
            {
                Console.WriteLine(item);
            }            
        }
        #endregion

        #region 4-2-3 FindFirst21Cメソッド
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var ym in yms)
            {
                //21世紀ならreturnして終了
                if (ym.Is21Century)
                {
                    return ym;
                }
            }
            return null;
        }
        #endregion

        #region 4-2-4 Exercise2_4メソッド
        private static void Exercise2_4(YearMonth[] ym)
        {
            var yearmonth = FindFirst21C(ym);

            //var s = yearmonth == null ? "21世紀のデータではありません。" : yearmonth.ToString();
            //Console.WriteLine(s);

            if (ym == null)
            {
                Console.WriteLine("21世紀のデータではありません。");
            }
            else
            {
                Console.WriteLine(yearmonth);
            }
        }
        #endregion

        #region 4-2-5 Exercise2_5メソッド
        private static void Exercise2_5(YearMonth[] ym)
        {
            var array = ym.Select(s => s.AddOneMonth()).ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
    }
}
