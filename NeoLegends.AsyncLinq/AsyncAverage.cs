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
        public static async Task<double> AverageAsync(IEnumerable<Task<int>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Average();
        }

        public static async Task<double> AverageAsync(IEnumerable<Task<long>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Average();
        }

        public static async Task<float> AverageAsync(IEnumerable<Task<float>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Average();
        }

        public static async Task<double> AverageAsync(IEnumerable<Task<double>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Average();
        }

        public static async Task<decimal> AverageAsync(IEnumerable<Task<decimal>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Average();
        }

        public static async Task<double> AverageAsync<T>(this IEnumerable<Task<T>> source, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Average(selector);
        }

        public static async Task<double> AverageAsync<T>(this IEnumerable<Task<T>> source, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Average(selector);
        }

        public static async Task<float> AverageAsync<T>(this IEnumerable<Task<T>> source, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Average(selector);
        }

        public static async Task<double> AverageAsync<T>(this IEnumerable<Task<T>> source, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Average(selector);
        }

        public static async Task<decimal> AverageAsync<T>(this IEnumerable<Task<T>> source, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Average(selector);
        }
    }
}
