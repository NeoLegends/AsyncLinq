using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncTake
    {
        public static async Task<IEnumerable<T>> TakeAsync<T>(this Task<IEnumerable<T>> collection, int count)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentOutOfRangeException>(count >= 0);

            return (await collection).Take(count);
        }

        public static async Task<IEnumerable<T>> TakeAsync<T>(this IEnumerable<Task<T>> collection, int count)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentOutOfRangeException>(count >= 0);

            return (await Task.WhenAll(collection)).Take(count);
        }
    }
}
