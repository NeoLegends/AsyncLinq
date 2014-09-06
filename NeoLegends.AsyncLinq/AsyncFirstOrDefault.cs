using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncFirstOrDefault
    {
        public static Task<T> FirstOrDefaultAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            IList<Task<T>> list = collection as IList<Task<T>>;
            if (list != null)
            {
                if (list.Count > 0)
                {
                    return list[0];
                }
                else
                {
                    return Task.FromResult(default(T));
                }
            }

            using (IEnumerator<Task<T>> enumerator = collection.GetEnumerator())
            {
                return enumerator.MoveNext() ? enumerator.Current : Task.FromResult(default(T));
            }
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this IEnumerable<Task<T>> collection, Predicate<T> predicate)
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

        public static async Task<T> FirstFinishedOrDefaultAsync<T>(this IEnumerable<Task<T>> collection, Predicate<T> predicate)
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

            return default(T);
        }
    }
}
