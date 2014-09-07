using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncOfType
    {
        public static async Task<IEnumerable<TOut>> OfTypeAsync<TIn, TOut>(this Task<IEnumerable<TIn>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).OfType<TOut>();
        }

        public static async Task<IEnumerable<TOut>> OfTypeAsync<TIn, TOut>(this IEnumerable<Task<TIn>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).OfType<TOut>();
        }
    }
}
