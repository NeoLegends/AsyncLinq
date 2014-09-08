using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncToLookup
    {
        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(this Task<IEnumerable<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection).ToLookup(keySelector);
        }

        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(this IEnumerable<Task<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await Task.WhenAll(collection)).ToLookup(keySelector);
        }

        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(
            this Task<IEnumerable<T>> collection, 
            Func<T, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection).ToLookup(keySelector, keyComparer);
        }

        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection)).ToLookup(keySelector, keyComparer);
        }

        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<T, TKey, TElement>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);

            return (await collection).ToLookup(keySelector, elementSelector);
        }

        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<T, TKey, TElement>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);

            return (await Task.WhenAll(collection)).ToLookup(keySelector, elementSelector);
        }

        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<T, TKey, TElement>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection).ToLookup(keySelector, elementSelector, keyComparer);
        }

        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<T, TKey, TElement>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection)).ToLookup(keySelector, elementSelector, keyComparer);
        }
    }
}
