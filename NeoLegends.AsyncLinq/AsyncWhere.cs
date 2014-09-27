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
        public static async Task<IEnumerable<T>> WhereAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).Where(predicate);
        }

        public static async Task<IEnumerable<T>> WhereAsync<T>(this Task<IEnumerable<T>> collection, Func<T, Task<bool>> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<T> results = new List<T>();
            foreach (T tIn in await collection)
            {
                if (await predicate(tIn))
                {
                    results.Add(tIn);
                }
            }
            return results;
        }

        public static async Task<IEnumerable<T>> WhereAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Where(predicate);
        }

        public static async Task<IEnumerable<T>> WhereAsync<T>(this IEnumerable<Task<T>> collection, Func<T, Task<bool>> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<T> results = new List<T>();
            foreach (T tIn in await Task.WhenAll(collection))
            {
                if (await predicate(tIn))
                {
                    results.Add(tIn);
                }
            }
            return results;
        }

        public static async Task<IEnumerable<T>> WhereAsync<T>(this Task<IEnumerable<T>> collection, Func<T, int, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).Where(predicate);
        }

        public static async Task<IEnumerable<T>> WhereAsync<T>(this Task<IEnumerable<T>> collection, Func<T, int, Task<bool>> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<T> results = new List<T>();
            int index = 0;
            foreach (T tIn in await collection)
            {
                if (await predicate(tIn, index++))
                {
                    results.Add(tIn);
                }
            }
            return results;
        }

        public static async Task<IEnumerable<T>> WhereAsync<T>(this IEnumerable<Task<T>> collection, Func<T, int, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Where(predicate);
        }

        public static async Task<IEnumerable<T>> WhereAsync<T>(this IEnumerable<Task<T>> collection, Func<T, int, Task<bool>> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            List<T> results = new List<T>();
            int index = 0;
            foreach (T tIn in await Task.WhenAll(collection))
            {
                if (await predicate(tIn, index++))
                {
                    results.Add(tIn);
                }
            }
            return results;
        }
    }
}
