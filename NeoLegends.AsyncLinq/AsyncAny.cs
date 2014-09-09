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
        public static async Task<bool> AnyAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection).Any(predicate);
        }

        public static async Task<bool> AnyAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<Task<T>> workingCopy = collection.ToList();
            while (workingCopy.Any())
            {
                Task<T> finishedTask = await Task.WhenAny(collection);
                if (predicate(finishedTask.Result))
                {
                    return true;
                }
                else
                {
                    workingCopy.Remove(finishedTask);
                }
            }

            return false;
        }
    }
}
