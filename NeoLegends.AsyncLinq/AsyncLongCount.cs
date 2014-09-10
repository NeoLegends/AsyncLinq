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
        public static async Task<long> LongCountAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).LongCount();
        }

        public static async Task<long> LongCountAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).LongCount(predicate);
        }

        public static async Task<long> LongCountAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).LongCount(predicate);
        }
    }
}
