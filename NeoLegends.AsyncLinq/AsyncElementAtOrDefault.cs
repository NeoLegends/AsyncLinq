using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncElementAtOrDefault
    {
        public static async Task<T> ElementAtOrDefaultAsync<T>(this Task<IEnumerable<T>> collection, int index)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentOutOfRangeException>(index >= 0);

            return (await collection).ElementAtOrDefault(index);
        }
        
        public static async Task<T> ElementAtOrDefaultAsync<T>(this IEnumerable<Task<T>> collection, int index)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentOutOfRangeException>(index >= 0);

            return (await Task.WhenAll(collection)).ElementAtOrDefault(index);
        }
    }
}
