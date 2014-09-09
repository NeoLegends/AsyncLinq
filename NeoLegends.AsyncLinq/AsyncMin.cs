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
        public static async Task<int> MinAsync(this Task<IEnumerable<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Min();
        }

        public static async Task<int> MinAsync(this IEnumerable<Task<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Min();
        }

        public static async Task<long> MinAsync(this Task<IEnumerable<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Min();
        }

        public static async Task<long> MinAsync(this IEnumerable<Task<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Min();
        }

        public static async Task<float> MinAsync(this Task<IEnumerable<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Min();
        }

        public static async Task<float> MinAsync(this IEnumerable<Task<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Min();
        }

        public static async Task<double> MinAsync(this Task<IEnumerable<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Min();
        }

        public static async Task<double> MinAsync(this IEnumerable<Task<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Min();
        }

        public static async Task<decimal> MinAsync(this Task<IEnumerable<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Min();
        }

        public static async Task<decimal> MinAsync(this IEnumerable<Task<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Min();
        }

        public static async Task<int> MinAsync<T>(this Task<IEnumerable<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Min(selector);
        }

        public static async Task<int> MinAsync<T>(this IEnumerable<Task<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Min(selector);
        }

        public static async Task<long> MinAsync<T>(this Task<IEnumerable<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Min(selector);
        }

        public static async Task<long> MinAsync<T>(this IEnumerable<Task<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Min(selector);
        }

        public static async Task<float> MinAsync<T>(this Task<IEnumerable<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Min(selector);
        }

        public static async Task<float> MinAsync<T>(this IEnumerable<Task<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Min(selector);
        }

        public static async Task<double> MinAsync<T>(this Task<IEnumerable<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Min(selector);
        }

        public static async Task<double> MinAsync<T>(this IEnumerable<Task<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Min(selector);
        }

        public static async Task<decimal> MinAsync<T>(this Task<IEnumerable<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Min(selector);
        }

        public static async Task<decimal> MinAsync<T>(this IEnumerable<Task<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Min(selector);
        }
    }
}
