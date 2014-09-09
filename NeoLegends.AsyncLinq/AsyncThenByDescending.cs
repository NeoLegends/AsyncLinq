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
        public static async Task<IEnumerable<T>> ThenByDescendingAsync<T, TKey>(this Task<IOrderedEnumerable<T>> collection, Func<T, TKey> keySelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection).ThenByDescending(keySelector);
        }

        public static async Task<IEnumerable<T>> ThenByDescendingAsync<T, TKey>(
            this Task<IOrderedEnumerable<T>> collection,
            Func<T, TKey> keySelector,
            IComparer<TKey> comparer)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(keySelector != null);

            return (await collection).ThenByDescending(keySelector, comparer);
        }
    }
}
