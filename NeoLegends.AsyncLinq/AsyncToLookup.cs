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
        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(this Task<IEnumerable<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection.ConfigureAwait(false)).ToLookup(keySelector);
        }

        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(this IEnumerable<Task<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToLookup(keySelector);
        }

        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(
            this Task<IEnumerable<T>> collection, 
            Func<T, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await collection.ConfigureAwait(false)).ToLookup(keySelector, keyComparer);
        }

        public static async Task<ILookup<TKey, T>> ToLookupAsync<T, TKey>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToLookup(keySelector, keyComparer);
        }

        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<T, TKey, TElement>(
            this Task<IEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);

            return (await collection.ConfigureAwait(false)).ToLookup(keySelector, elementSelector);
        }

        public static async Task<ILookup<TKey, TElement>> ToLookupAsync<T, TKey, TElement>(
            this IEnumerable<Task<T>> collection,
            Func<T, TKey> keySelector,
            Func<T, TElement> elementSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);
            Contract.Requires<ArgumentNullException>(elementSelector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToLookup(keySelector, elementSelector);
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

            return (await collection.ConfigureAwait(false)).ToLookup(keySelector, elementSelector, keyComparer);
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

            return (await Task.WhenAll(collection).ConfigureAwait(false)).ToLookup(keySelector, elementSelector, keyComparer);
        }
    }
}
