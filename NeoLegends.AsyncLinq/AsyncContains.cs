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
        public static async Task<bool> ContainsAsync<T>(this Task<IEnumerable<T>> collection, T item)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Contains(item);
        }

        public static async Task<bool> ContainsAsync<T>(this IEnumerable<Task<T>> collection, T item)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Contains(item);
        }

        public static async Task<bool> ContainsAsync<T>(this Task<IEnumerable<T>> collection, T item, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            return (await collection.ConfigureAwait(false)).Contains(item, comparer);
        }

        public static async Task<bool> ContainsAsync<T>(this IEnumerable<Task<T>> collection, T item, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Contains(item, comparer);
        }
    }
}
