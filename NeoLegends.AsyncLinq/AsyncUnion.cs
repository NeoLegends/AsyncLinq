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
        public static async Task<IEnumerable<T>> UnionAsync<T>(this Task<IEnumerable<T>> first, Task<IEnumerable<T>> second)
        {
            Contract.Requires<ArgumentNullException>(first != null);
            Contract.Requires<ArgumentNullException>(second != null);

            IEnumerable<T>[] whenAllResults = await Task.WhenAll(first, second).ConfigureAwait(false);
            return whenAllResults[0].Union(whenAllResults[1]);
        }

        public static async Task<IEnumerable<T>> UnionAsync<T>(this IEnumerable<Task<T>> first, IEnumerable<Task<T>> second)
        {
            Contract.Requires<ArgumentNullException>(first != null);
            Contract.Requires<ArgumentNullException>(second != null);

            T[][] whenAllResults = await Task.WhenAll(Task.WhenAll(first), Task.WhenAll(second)).ConfigureAwait(false);
            return whenAllResults[0].Union(whenAllResults[1]);
        }

        public static async Task<IEnumerable<T>> UnionAsync<T>(this Task<IEnumerable<T>> first, Task<IEnumerable<T>> second, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(first != null);
            Contract.Requires<ArgumentNullException>(second != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            IEnumerable<T>[] whenAllResults = await Task.WhenAll(first, second).ConfigureAwait(false);
            return whenAllResults[0].Union(whenAllResults[1], comparer);
        }

        public static async Task<IEnumerable<T>> UnionAsync<T>(this IEnumerable<Task<T>> first, IEnumerable<Task<T>> second, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(first != null);
            Contract.Requires<ArgumentNullException>(second != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            T[][] whenAllResults = await Task.WhenAll(Task.WhenAll(first), Task.WhenAll(second)).ConfigureAwait(false);
            return whenAllResults[0].Union(whenAllResults[1], comparer);
        }
    }
}
