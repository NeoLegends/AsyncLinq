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
        public static async Task<IEnumerable<T>> SkipWhileAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).SkipWhile(predicate);
        }

        public static async Task<IEnumerable<T>> SkipWhileAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).SkipWhile(predicate);
        }

        public static async Task<IEnumerable<T>> SkipWhileAsync<T>(this Task<IEnumerable<T>> collection, Func<T, int, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).SkipWhile(predicate);
        }

        public static async Task<IEnumerable<T>> SkipWhileAsync<T>(this IEnumerable<Task<T>> collection, Func<T, int, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).SkipWhile(predicate);
        }
    }
}
