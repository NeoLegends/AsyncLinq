using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
    public static partial class AsyncEnumerable
    {
        public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            this Task<IEnumerable<TSource>> collection, 
            Func<TSource, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection.ConfigureAwait(false)).ToDictionary(keySelector);
        }

        public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            this IEnumerable<Task<TSource>> collection, 
            Func<TSource, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToDictionary(keySelector);
        }

        public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            this Task<IEnumerable<TSource>> collection, 
            Func<TSource, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection.ConfigureAwait(false)).ToDictionary(keySelector, keyComparer);
        }

        public static async Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            this IEnumerable<Task<TSource>> collection, 
            Func<TSource, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToDictionary(keySelector, keyComparer);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            this Task<IEnumerable<TSource>> collection,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);

            return (await collection.ConfigureAwait(false)).ToDictionary(keySelector, elementSelector);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            this IEnumerable<Task<TSource>> collection,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToDictionary(keySelector, elementSelector);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            this Task<IEnumerable<TSource>> collection,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection.ConfigureAwait(false)).ToDictionary(keySelector, elementSelector, keyComparer);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            this IEnumerable<Task<TSource>> collection,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToDictionary(keySelector, elementSelector, keyComparer);
        }
    }
}
