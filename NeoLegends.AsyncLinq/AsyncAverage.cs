using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncAverage
    {
        public static async Task<double> AverageAsync(this Task<IEnumerable<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Average();
        }

        public static async Task<double> AverageAsync(this IEnumerable<Task<int>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Average();
        }

        public static async Task<double> AverageAsync(this Task<IEnumerable<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Average();
        }

        public static async Task<double> AverageAsync(this IEnumerable<Task<long>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Average();
        }

        public static async Task<float> AverageAsync(this Task<IEnumerable<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Average();
        }

        public static async Task<float> AverageAsync(this IEnumerable<Task<float>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Average();
        }

        public static async Task<double> AverageAsync(this Task<IEnumerable<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Average();
        }

        public static async Task<double> AverageAsync(this IEnumerable<Task<double>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Average();
        }

        public static async Task<decimal> AverageAsync(this Task<IEnumerable<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await collection).Average();
        }

        public static async Task<decimal> AverageAsync(this IEnumerable<Task<decimal>> collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            return (await Task.WhenAll(collection)).Average();
        }

        public static async Task<double> AverageAsync<T>(this Task<IEnumerable<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Average(selector);
        }

        public static async Task<double> AverageAsync<T>(this IEnumerable<Task<T>> collection, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Average(selector);
        }

        public static async Task<double> AverageAsync<T>(this Task<IEnumerable<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Average(selector);
        }

        public static async Task<double> AverageAsync<T>(this IEnumerable<Task<T>> collection, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Average(selector);
        }

        public static async Task<float> AverageAsync<T>(this Task<IEnumerable<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Average(selector);
        }

        public static async Task<float> AverageAsync<T>(this IEnumerable<Task<T>> collection, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Average(selector);
        }

        public static async Task<double> AverageAsync<T>(this Task<IEnumerable<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Average(selector);
        }

        public static async Task<double> AverageAsync<T>(this IEnumerable<Task<T>> collection, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Average(selector);
        }

        public static async Task<decimal> AverageAsync<T>(this Task<IEnumerable<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await collection).Average(selector);
        }

        public static async Task<decimal> AverageAsync<T>(this IEnumerable<Task<T>> collection, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(collection)).Average(selector);
        }
    }
}
