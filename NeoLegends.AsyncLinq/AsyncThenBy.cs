using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncThenBy
    {
        public static async Task<IEnumerable<T>> ThenByAsync<T, TKey>(this Task<IOrderedEnumerable<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection).ThenBy(keySelector);
        }

        //public static async Task<IEnumerable<T>> ThenByAsync<T, TKey>(this IOrderedEnumerable<Task<T>> collection, Func<T, TKey> keySelector)
        //{
        //    Contract.Requires<ArgumentNullException>(collection != null);
        //    Contract.Requires<ArgumentNullException>(keySelector != null);

        //    return new OrderedEnumerable<T>(await Task.WhenAll(collection), comparer).ThenBy(keySelector);
        //}

        public static async Task<IEnumerable<T>> ThenByAsync<T, TKey>(
            this Task<IOrderedEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            IComparer<TKey> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection).ThenBy(keySelector, comparer);
        }

        //public static async Task<IEnumerable<T>> ThenByAsync<T, TKey>(
        //    this IOrderedEnumerable<Task<T>> collection, 
        //    Func<T, TKey> keySelector,
        //    IComparer<TKey> comparer)
        //{
        //    Contract.Requires<ArgumentNullException>(collection != null);
        //    Contract.Requires<ArgumentNullException>(keySelector != null);

        //    return new OrderedEnumerable<T>(await Task.WhenAll(collection), comparer).ThenBy(keySelector, comparer);
        //}

        //private struct OrderedEnumerable<T> : IOrderedEnumerable<T>
        //{
        //    private readonly IEnumerable<T> collection;

        //    private readonly IComparer<T> comparer;

        //    public OrderedEnumerable(IEnumerable<T> collection, IComparer<T> comparer)
        //    {
        //        Contract.Requires<ArgumentNullException>(collection != null);
        //        Contract.Requires<ArgumentNullException>(comparer != null);

        //        this.collection = collection;
        //        this.comparer = comparer;
        //    }

        //    public IOrderedEnumerable<T> CreateOrderedEnumerable<TKey>(Func<T, TKey> keySelector, IComparer<TKey> comparer, bool descending)
        //    {
        //        return descending ?
        //            this.collection.OrderByDescending(keySelector, comparer) :
        //            this.collection.OrderBy(keySelector, comparer);
        //    }

        //    public IEnumerator<T> GetEnumerator()
        //    {
        //        return this.collection.GetEnumerator();
        //    }

        //    IEnumerator IEnumerable.GetEnumerator()
        //    {
        //        return this.GetEnumerator();
        //    }
        //}
    }
}
