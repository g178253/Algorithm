using System;
using System.Collections.Generic;

namespace Algorithm.Sort
{
    /// <summary>
    /// 选择排序。
    /// </summary>
    /// <typeparam name="T">排序元素的类型。</typeparam>
    public sealed class SelectionSort<T> : SortBase<T> where T : IComparable
    {
        /// <summary>
        /// 对指定的集合进行排序。
        /// </summary>
        /// <param name="src">要排序的集合。</param>
        public override void Sort(IList<T> src)
        {
            if (src == null) return;

            for (Int32 i = 0; i < src.Count; i++)
            {
                var min = i;
                for (Int32 j = i + 1; j < src.Count; j++)
                {
                    if (Less(src[j], src[min]))
                    {
                        min = j;
                    }
                }

                if (i != min)
                {
                    Swap(src, i, min);
                }
            }
        }
    }
}
