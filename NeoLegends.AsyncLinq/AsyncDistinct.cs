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
        public static async Task<IEnumerable<T>> DistinctAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Distinct();
        }

        public static async Task<IEnumerable<T>> DistinctAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Distinct();
        }

        public static async Task<IEnumerable<T>> DistinctAsync<T>(this Task<IEnumerable<T>> collection, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            return (await collection.ConfigureAwait(false)).Distinct(comparer);
        }

        public static async Task<IEnumerable<T>> DistinctAsync<T>(this IEnumerable<Task<T>> collection, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Distinct(comparer);
        }
    }
}
