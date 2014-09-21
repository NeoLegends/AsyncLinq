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
        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this Task<IEnumerable<TIn>> collection, Func<TIn, TOut> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).Select(selector);
        }

        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this Task<IEnumerable<TIn>> collection, Func<TIn, Task<TOut>> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            List<TOut> results = new List<TOut>();
            foreach (TIn tIn in await collection)
            {
                results.Add(await selector(tIn));
            }
            return results;
        }

        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this IEnumerable<Task<TIn>> collection, Func<TIn, TOut> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Select(selector);
        }

        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this IEnumerable<Task<TIn>> collection, Func<TIn, Task<TOut>> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            List<TOut> results = new List<TOut>();
            foreach (TIn tIn in await Task.WhenAll(collection))
            {
                results.Add(await selector(tIn));
            }
            return results;
        }

        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this Task<IEnumerable<TIn>> collection, Func<TIn, int, TOut> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).Select(selector);
        }

        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this Task<IEnumerable<TIn>> collection, Func<TIn, int, Task<TOut>> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            List<TOut> results = new List<TOut>();
            int index = 0;
            foreach (TIn tIn in await collection)
            {
                results.Add(await selector(tIn, index++));
            }
            return results;
        }

        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this IEnumerable<Task<TIn>> collection, Func<TIn, int, TOut> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Select(selector);
        }

        public static async Task<IEnumerable<TOut>> SelectAsync<TIn, TOut>(this IEnumerable<Task<TIn>> collection, Func<TIn, int, Task<TOut>> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            List<TOut> results = new List<TOut>();
            int index = 0;
            foreach (TIn tIn in await Task.WhenAll(collection))
            {
                results.Add(await selector(tIn, index++));
            }
            return results;
        }
    }
}
