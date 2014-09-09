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
        public static async Task<bool> SequenceEqualAsync<T>(this Task<IEnumerable<T>> collection, Task<IEnumerable<T>> comparand)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparand != null);

            IEnumerable<T>[] whenAllResults = await Task.WhenAll(collection, comparand);
            return whenAllResults[0].SequenceEqual(whenAllResults[1]);
        }

        public static async Task<bool> SequenceEqualAsync<T>(this IEnumerable<Task<T>> collection, IEnumerable<Task<T>> comparand)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparand != null);

            T[][] whenAllResults = await Task.WhenAll(Task.WhenAll(collection), Task.WhenAll(comparand));
            return whenAllResults[0].SequenceEqual(whenAllResults[1]);
        }

        public static async Task<bool> SequenceEqualAsync<T>(this Task<IEnumerable<T>> collection, Task<IEnumerable<T>> comparand, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparand != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            IEnumerable<T>[] whenAllResults = await Task.WhenAll(collection, comparand);
            return whenAllResults[0].SequenceEqual(whenAllResults[1], comparer);
        }

        public static async Task<bool> SequenceEqualAsync<T>(this IEnumerable<Task<T>> collection, IEnumerable<Task<T>> comparand, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(comparand != null);
            Contract.Requires<ArgumentNullException>(comparer != null);

            T[][] whenAllResults = await Task.WhenAll(Task.WhenAll(collection), Task.WhenAll(comparand));
            return whenAllResults[0].SequenceEqual(whenAllResults[1], comparer);
        }
    }
}
