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
        public static async Task<T> SingleOrDefaultAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).SingleOrDefault();
        }

        public static Task<T> SingleOrDefaultAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            List<Task<T>> workingCopy = collection.ToList();
            return Task.WhenAny(workingCopy).ContinueWith(t =>
            {
                workingCopy.Remove(t.Result);
                return (workingCopy.Any()) ? default(T) : t.Result.Result;
            });
        }

        public static async Task<T> SingleOrDefaultAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection).SingleOrDefault(predicate);
        }

        public static Task<T> SingleOrDefaultAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            throw new NotImplementedException();
        }
    }
}
