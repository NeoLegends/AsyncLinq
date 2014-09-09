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
        public static async Task<int> SumAsync(this Task<IEnumerable<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Sum();
        }

        public static async Task<int> SumAsync(this IEnumerable<Task<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Sum();
        }

        public static async Task<long> SumAsync(this Task<IEnumerable<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Sum();
        }

        public static async Task<long> SumAsync(this IEnumerable<Task<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Sum();
        }

        public static async Task<float> SumAsync(this Task<IEnumerable<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Sum();
        }

        public static async Task<float> SumAsync(this IEnumerable<Task<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Sum();
        }

        public static async Task<double> SumAsync(this Task<IEnumerable<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Sum();
        }

        public static async Task<double> SumAsync(this IEnumerable<Task<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Sum();
        }

        public static async Task<decimal> SumAsync(this Task<IEnumerable<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Sum();
        }

        public static async Task<decimal> SumAsync(this IEnumerable<Task<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Sum();
        }

        public static async Task<int> SumAsync<T>(this Task<IEnumerable<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Sum(selector);
        }

        public static async Task<int> SumAsync<T>(this IEnumerable<Task<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Sum(selector);
        }

        public static async Task<long> SumAsync<T>(this Task<IEnumerable<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Sum(selector);
        }

        public static async Task<long> SumAsync<T>(this IEnumerable<Task<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Sum(selector);
        }

        public static async Task<float> SumAsync<T>(this Task<IEnumerable<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Sum(selector);
        }

        public static async Task<float> SumAsync<T>(this IEnumerable<Task<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Sum(selector);
        }

        public static async Task<double> SumAsync<T>(this Task<IEnumerable<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Sum(selector);
        }

        public static async Task<double> SumAsync<T>(this IEnumerable<Task<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Sum(selector);
        }

        public static async Task<decimal> SumAsync<T>(this Task<IEnumerable<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Sum(selector);
        }

        public static async Task<decimal> SumAsync<T>(this IEnumerable<Task<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Sum(selector);
        }
    }
}
