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
        public static async Task<IEnumerable<TOut>> SelectManyAsync<TIn, TOut>(
            this Task<IEnumerable<TIn>> collection, 
            Func<TIn, IEnumerable<TOut>> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).SelectMany(selector);
        }

        public static async Task<IEnumerable<TOut>> SelectManyAsync<TIn, TOut>(
            this IEnumerable<Task<TIn>> collection, 
            Func<TIn, IEnumerable<TOut>> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).SelectMany(selector);
        }

        public static async Task<IEnumerable<TOut>> SelectManyAsync<TIn, TCollection, TOut>(
            this Task<IEnumerable<TIn>> collection, 
            Func<TIn, IEnumerable<TCollection>> collectionSelector,
            Func<TIn, TCollection, TOut> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(collectionSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await collection.ConfigureAwait(false)).SelectMany(collectionSelector, resultSelector);
        }

        public static async Task<IEnumerable<TOut>> SelectManyAsync<TIn, TCollection, TOut>(
            this IEnumerable<Task<TIn>> collection,
            Func<TIn, IEnumerable<TCollection>> collectionSelector,
            Func<TIn, TCollection, TOut> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(collectionSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).SelectMany(collectionSelector, resultSelector);
        }

        public static async Task<IEnumerable<TOut>> SelectManyAsync<TIn, TCollection, TOut>(
            this Task<IEnumerable<TIn>> collection,
            Func<TIn, int, IEnumerable<TCollection>> collectionSelector,
            Func<TIn, TCollection, TOut> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(collectionSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await collection.ConfigureAwait(false)).SelectMany(collectionSelector, resultSelector);
        }

        public static async Task<IEnumerable<TOut>> SelectManyAsync<TIn, TCollection, TOut>(
            this IEnumerable<Task<TIn>> collection,
            Func<TIn, int, IEnumerable<TCollection>> collectionSelector,
            Func<TIn, TCollection, TOut> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(collectionSelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).SelectMany(collectionSelector, resultSelector);
        }
    }
}
