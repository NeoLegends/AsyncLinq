using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static partial class AsyncEnumerable
    {
        public static async Task<IEnumerable<IGrouping<TKey, T>>> GroupByAsync<T, TKey>(this Task<IEnumerable<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection).GroupBy(keySelector);
        }

        public static async Task<IEnumerable<IGrouping<TKey, T>>> GroupByAsync<T, TKey>(this IEnumerable<Task<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector);
        }

        public static async Task<IEnumerable<IGrouping<TKey, T>>> GroupByAsync<T, TKey>(
            this Task<IEnumerable<T>> collection, 
            Func<T, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection).GroupBy(keySelector, keyComparer);
        }

        public static async Task<IEnumerable<IGrouping<TKey, T>>> GroupByAsync<T, TKey>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector, keyComparer);
        }

        public static async Task<IEnumerable<IGrouping<TKey, TResult>>> GroupByAsync<T, TKey, TResult>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TResult> valueSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(valueSelector != null);

            return (await collection).GroupBy(keySelector, valueSelector);
        }

        public static async Task<IEnumerable<IGrouping<TKey, TResult>>> GroupByAsync<T, TKey, TResult>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TResult> valueSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(valueSelector != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector, valueSelector);
        }

        public static async Task<IEnumerable<IGrouping<TKey, TResult>>> GroupByAsync<T, TKey, TResult>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TResult> valueSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(valueSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection).GroupBy(keySelector, valueSelector, keyComparer);
        }

        public static async Task<IEnumerable<IGrouping<TKey, TResult>>> GroupByAsync<T, TKey, TResult>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TResult> valueSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(valueSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector, valueSelector, keyComparer);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TResult>(
            this Task<IEnumerable<T>> collection, 
            Func<T, TKey> keySelector,
            Func<TKey, IEnumerable<T>, TResult> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await collection).GroupBy(keySelector, resultSelector);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TResult>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<TKey, IEnumerable<T>, TResult> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector, resultSelector);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TResult>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<TKey, IEnumerable<T>, TResult> resultSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection).GroupBy(keySelector, resultSelector, keyComparer);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TResult>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<TKey, IEnumerable<T>, TResult> resultSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector, resultSelector, keyComparer);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TElement, TResult>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector,
            Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await collection).GroupBy(keySelector, elementSelector, resultSelector);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TElement, TResult>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector,
            Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector, elementSelector, resultSelector);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TElement, TResult>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector,
            Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection).GroupBy(keySelector, elementSelector, resultSelector, keyComparer);
        }

        public static async Task<IEnumerable<TResult>> GroupByAsync<T, TKey, TElement, TResult>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector,
            Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection)).GroupBy(keySelector, elementSelector, resultSelector, keyComparer);
        }
    }
}
