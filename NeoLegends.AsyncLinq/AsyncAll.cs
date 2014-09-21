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
        public static async Task<bool> AllAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).All(predicate);
        }

        public static async Task<bool> AllAsync<T>(this Task<IEnumerable<T>> collection, Func<T, Task<bool>> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            foreach (T item in await collection)
            {
                if (!(await predicate(item)))
                {
                    return false;
                }
            }
            return true;
        }

        public static async Task<bool> AllAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).All(predicate);
        }

        public static async Task<bool> AllAsync<T>(this IEnumerable<Task<T>> collection, Func<T, Task<bool>> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<Task<T>> tasks = collection.ToList();
            while (tasks.Any())
            {
                Task<T> finishedTask = await Task.WhenAny(tasks);
                if (await predicate(finishedTask.Result))
                {
                    tasks.Remove(finishedTask);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
