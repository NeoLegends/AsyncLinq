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
        public static async Task<T[]> ToArrayAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).ToArray();
        }

        public static async Task<T[]> ToArrayAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return await Task.WhenAll(collection).ConfigureAwait(false);
        }
    }
}
