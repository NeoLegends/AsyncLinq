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
        public static async Task<T> FirstOrDefaultAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).FirstOrDefault();
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).FirstOrDefault(predicate);
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            foreach (Task<T> task in collection)
            {
                T result = await task;
                if (predicate(result))
                {
                    return result;
                }
            }

            return default(T);
        }
        
        public static async Task<T> FirstFinishedOrDefaultAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            try
            {
                return (await Task.WhenAny(collection)).Result;
            }
            catch (ArgumentException)
            {
                return default(T);
            }
        }

        public static async Task<T> FirstFinishedOrDefaultAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<Task<T>> workingCopy = collection.ToList();
            while (workingCopy.Any())
            {
                Task<T> finishedTask = await Task.WhenAny(workingCopy);
                if (predicate(finishedTask.Result))
                {
                    return finishedTask.Result;
                }
                else
                {
                    workingCopy.Remove(finishedTask);
                }
            }

            return default(T);
        }
    }
}
