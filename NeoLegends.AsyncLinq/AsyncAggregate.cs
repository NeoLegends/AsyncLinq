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
        public static async Task<T> AggregateAsync<T>(this Task<IEnumerable<T>> collection, Func<T, T, T> aggregator)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(aggregator != null);

            return (await collection.ConfigureAwait(false)).Aggregate(aggregator);
        }

        public static async Task<T> AggregateAsync<T>(this IEnumerable<Task<T>> collection, Func<T, T, T> aggregator)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(aggregator != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Aggregate(aggregator);
        }

        public static async Task<TAccumulate> AggregateAsync<T, TAccumulate>(
            this Task<IEnumerable<T>> collection, 
            TAccumulate seed, 
            Func<TAccumulate, T, TAccumulate> aggregator)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(aggregator != null);

            return (await collection.ConfigureAwait(false)).Aggregate(seed, aggregator);
        }

        public static async Task<TAccumulate> AggregateAsync<T, TAccumulate>(
            this IEnumerable<Task<T>> collection, 
            TAccumulate seed, 
            Func<TAccumulate, T, TAccumulate> aggregator)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(aggregator != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Aggregate(seed, aggregator);
        }

        public static async Task<T> AggregateAsync<T, TAccumulate>(
            this Task<IEnumerable<T>> collection, 
            TAccumulate seed, 
            Func<TAccumulate, T, TAccumulate> aggregator,
            Func<TAccumulate, T> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(aggregator != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await collection.ConfigureAwait(false)).Aggregate(seed, aggregator, resultSelector);
        }

        public static async Task<T> AggregateAsync<T, TAccumulate>(
            this IEnumerable<Task<T>> collection,
            TAccumulate seed,
            Func<TAccumulate, T, TAccumulate> aggregator,
            Func<TAccumulate, T> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(aggregator != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Aggregate(seed, aggregator, resultSelector);
        }
    }
}
