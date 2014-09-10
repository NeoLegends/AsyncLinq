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
        public static async Task<T> SingleAsync<T>(this Task<IEnumerable<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Single();
        }

        public static Task<T> SingleAsync<T>(this IEnumerable<Task<T>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            List<Task<T>> workingCopy = collection.ToList();
            return Task.WhenAny(workingCopy).ContinueWith(t =>
            {
                workingCopy.Remove(t.Result);
                if (workingCopy.Any())
                {
                    throw new InvalidOperationException("Multiple elements were in the list.");
                }
                else
                {
                    return t.Result.Result;
                }
            });
        }

        public static async Task<T> SingleAsync<T>(this Task<IEnumerable<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            return (await collection.ConfigureAwait(false)).Single(predicate);
        }

        public static Task<T> SingleAsync<T>(this IEnumerable<Task<T>> collection, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(predicate != null);

            throw new NotImplementedException();
        }
    }
}
