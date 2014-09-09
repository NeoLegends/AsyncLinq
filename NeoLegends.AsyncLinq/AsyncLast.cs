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
        public static async Task<T> LastAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Last();
        }

        public static async Task<T> LastAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection).Last(predicate);
        }

        public static async Task<T> LastAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
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

            throw new InvalidOperationException("No element matched the predicate or the collection was empty.");
        }

        public static async Task<T> LastFinishedAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            List<Task<T>> workingCopy = collection.ToList();
            Task<T> current = null;
            while (workingCopy.Any())
            {
                current = await Task.WhenAny(workingCopy);
                workingCopy.Remove(current);
            }
            return current.Result;
        }

        public static async Task<T> LastFinishedAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<Task<T>> workingCopy = collection.ToList();
            Task<T> current = null;
            while (workingCopy.Any())
            {
                Task<T> finishedTask = await Task.WhenAny(workingCopy);
                if (predicate(finishedTask.Result))
                {
                    current = finishedTask;
                    workingCopy.Remove(current);
                }
            }
            return current.Result;
        }
    }
}
