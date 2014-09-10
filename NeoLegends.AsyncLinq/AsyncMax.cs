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
        public static async Task<int> MaxAsync(this Task<IEnumerable<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Max();
        }

        public static async Task<int> MaxAsync(this IEnumerable<Task<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max();
        }

        public static async Task<long> MaxAsync(this Task<IEnumerable<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Max();
        }

        public static async Task<long> MaxAsync(this IEnumerable<Task<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max();
        }

        public static async Task<float> MaxAsync(this Task<IEnumerable<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Max();
        }

        public static async Task<float> MaxAsync(this IEnumerable<Task<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max();
        }

        public static async Task<double> MaxAsync(this Task<IEnumerable<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Max();
        }

        public static async Task<double> MaxAsync(this IEnumerable<Task<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max();
        }

        public static async Task<decimal> MaxAsync(this Task<IEnumerable<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection.ConfigureAwait(false)).Max();
        }

        public static async Task<decimal> MaxAsync(this IEnumerable<Task<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max();
        }

        public static async Task<int> MaxAsync<T>(this Task<IEnumerable<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).Max(selector);
        }

        public static async Task<int> MaxAsync<T>(this IEnumerable<Task<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max(selector);
        }

        public static async Task<long> MaxAsync<T>(this Task<IEnumerable<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).Max(selector);
        }

        public static async Task<long> MaxAsync<T>(this IEnumerable<Task<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max(selector);
        }

        public static async Task<float> MaxAsync<T>(this Task<IEnumerable<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).Max(selector);
        }

        public static async Task<float> MaxAsync<T>(this IEnumerable<Task<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max(selector);
        }

        public static async Task<double> MaxAsync<T>(this Task<IEnumerable<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).Max(selector);
        }

        public static async Task<double> MaxAsync<T>(this IEnumerable<Task<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max(selector);
        }

        public static async Task<decimal> MaxAsync<T>(this Task<IEnumerable<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection.ConfigureAwait(false)).Max(selector);
        }

        public static async Task<decimal> MaxAsync<T>(this IEnumerable<Task<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection).ConfigureAwait(false)).Max(selector);
        }
    }
}
