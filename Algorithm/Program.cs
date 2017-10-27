using System;
using System.Collections.Generic;
using Algorithm.Sort;

namespace Algorithm
{
    class Program
    {
        static void Main(String[] args)
        {
            var col = GetUnorderedCollection();
            Console.WriteLine("排序前集合有序：" + IsSorted(col));

            //var sort = new BubbleSort<Int32>();
            var sort = new SelectSort<Int32>();
            sort.Sort(col);
            Console.WriteLine("排序后集合有序：" + IsSorted(col));

            Console.WriteLine("排序结果：");
            PrintCollection(col);

            Console.WriteLine("按下任意键退出...");
            Console.ReadKey();
        }

        /// <summary>
        /// 判断指定的集合是否有序。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="src">要测试的集合。</param>
        /// <returns>如果集合有序，返回 true；否则返回 false。</returns>
        static Boolean IsSorted<T>(IList<T> src) where T : IComparable
        {
            if (src == null) return false;

            for (Int32 i = 0; i < src.Count - 1; i++)
            {
                for (Int32 j = i + 1; j < src.Count; j++)
                {
                    if (src[i].CompareTo(src[j]) > 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 获取一个无序集合。
        /// </summary>
        /// <returns>一个无序集合。</returns>
        static IList<Int32> GetUnorderedCollection()
        {
            var col = new List<Int32>(1000);

            var rdm = new Random();
            for (int i = 0; i < 1000; i++)
            {
                col.Add(rdm.Next(0, 3000));
            }

            return col;
        }

        /// <summary>
        /// 打印指定的集合。
        /// </summary>
        /// <typeparam name="T">集合元素的类型。</typeparam>
        /// <param name="src">要打印的集合。</param>
        static void PrintCollection<T>(IList<T> src)
        {
            if (src == null) return;

            for (int i = 0; i < src.Count - 1; i++)
            {
                Console.Write(src[i] + " ");
            }
            Console.WriteLine(src[src.Count-1]);
        }
    }
}
