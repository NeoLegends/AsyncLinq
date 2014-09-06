using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncFirst
    {
        public static Task<T> FirstAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            IList<Task<T>> list = collection as IList<Task<T>>;
            if (list != null && list.Count > 0)
            {
                return list[0];
            }

            using (IEnumerator<Task<T>> enumerator = collection.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    return enumerator.Current;
                }
                else
                {
                    throw new InvalidOperationException("The source sequence was empty.");
                }
            }
        }

        public static async Task<T> FirstAsync<T>(this IEnumerable<Task<T>> collection, Predicate<T> predicate)
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

            throw new InvalidOperationException("No element matched the predicate or the collection was empty.");
        }

        public static async Task<T> FirstFinishedAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAny(collection)).Result;
        }

        public static async Task<T> FirstFinishedAsync<T>(this IEnumerable<Task<T>> collection, Predicate<T> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<Task<T>> workingCopy = collection.ToList();
            while (workingCopy.Any())
            {
                Task<T> finishedTask = await Task.WhenAny(collection);
                if (predicate(finishedTask.Result))
                {
                    return finishedTask.Result;
                }
                else
                {
                    workingCopy.Remove(finishedTask);
                }
            }

            throw new InvalidOperationException("No element matched the predicate or the collection was empty.");
        }
    }
}
