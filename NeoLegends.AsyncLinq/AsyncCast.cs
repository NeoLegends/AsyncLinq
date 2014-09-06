using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncCast
    {
        public static async Task<IEnumerable<TOut>> CastAsync<TIn, TOut>(this IEnumerable<Task<TIn>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Cast<TOut>();
        }
    }
}
