using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Algorithm.Sort
{
    /// <summary>
    /// 排序基类。
    /// </summary>
    /// <typeparam name="T">排序元素的类型。</typeparam>
    public abstract class SortBase<T> where T : IComparable
    {
        /// <summary>
        /// 判断左边的元素，是否小于右边。
        /// </summary>
        /// <param name="left">左边的元素。</param>
        /// <param name="right">右边的元素。</param>
        /// <returns>如果左边的元素小于右边，返回 true；否则返回 false。</returns>
        protected bool Less(T left, T right)
        {
            Contract.Assert(left != null);
            Contract.Assert(right != null);

            return left.CompareTo(right) < 0;
        }

        /// <summary>
        /// 根据元素索引，交换指定集合中的两个元素。
        /// </summary>
        /// <param name="src">要操作的集合。</param>
        /// <param name="i">其中一个元素的索引。</param>
        /// <param name="j">另一个元素的索引。</param>
        protected void Swap(IList<T> src, int i, int j)
        {
            Contract.Assert(src != null);
            Contract.Assert(src.Count > i);
            Contract.Assert(src.Count > j);
            Contract.Assert(i >= 0);
            Contract.Assert(j >= 0);
            Contract.Assert(i != j);

            var tmp = src[i];
            src[i] = src[j];
            src[j] = tmp;
        }

        /// <summary>
        /// 对指定的集合进行排序。
        /// </summary>
        /// <param name="src">要排序的集合。</param>
        public abstract void Sort(IList<T> src);
    }
}
