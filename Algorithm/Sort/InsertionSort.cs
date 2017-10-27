using System;
using System.Collections.Generic;

namespace Algorithm.Sort
{
    /// <summary>
    /// 插入排序。
    /// </summary>
    /// <typeparam name="T">排序元素的类型。</typeparam>
    public sealed class InsertionSort<T> : SortBase<T> where T : IComparable
    {
        /// <summary>
        /// 对指定的集合进行排序。
        /// </summary>
        /// <param name="src">要排序的集合。</param>
        public override void Sort(IList<T> src)
        {
            if (src == null) return;

            var len = src.Count - 1; // 避免判断 j 是否过大。
            for (Int32 i = 0; i < len; i++)
            {
                //
                // 因为 j = i+1 > 0，因此 i > -1。
                // 对于整数而言，i > -1 等价于 i >= 0。
                //
                // 因为要将 src[j] 与左边的多个元素进行比较，
                // 所以索引 i 也要进行递减。
                //
                for (Int32 j = i + 1; j > 0; i--, j--)
                {
                    if (Less(src[j], src[i]))
                    {
                        Swap(src, j, i);
                    }
                    // src[j] 左边的都小于它。
                    else
                    {
                        break; // 避免多余的比较。
                    }
                }
            }
        }
    }
}
