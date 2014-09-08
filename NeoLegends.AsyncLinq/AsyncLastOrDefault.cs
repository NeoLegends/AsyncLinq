using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncLastOrDefault
    {
        public static async Task<T> LastOrDefaultAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).LastOrDefault();
        }

        public static Task<T> LastOrDefaultAsync<T>(this IEnumerable<Task<T>> collection)
        {
            // Even though this method does nothing more than the regular .LastOrDefault
            // we have it because it would be confusing if it was missing.

            Contract.Requires<ArgumentNullException>(collection != null);

            return collection.LastOrDefault();
        }

        public static async Task<T> LastOrDefaultAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection).LastOrDefault(predicate);
        }

        public static async Task<T> LastOrDefaultAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            foreach (Task<T> task in collection.Reverse())
            {
                T result = await task;
                if (predicate(result))
                {
                    return result;
                }
            }

            return default(T);
        }
    }
}
