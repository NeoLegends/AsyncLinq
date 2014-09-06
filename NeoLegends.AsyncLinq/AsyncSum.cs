using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncSum
    {
        public static async Task<int> SumAsync(IEnumerable<Task<int>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Sum();
        }

        public static async Task<long> SumAsync(IEnumerable<Task<long>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Sum();
        }

        public static async Task<float> SumAsync(IEnumerable<Task<float>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Sum();
        }

        public static async Task<double> SumAsync(IEnumerable<Task<double>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Sum();
        }

        public static async Task<decimal> SumAsync(IEnumerable<Task<decimal>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Sum();
        }

        public static async Task<int> SumAsync<T>(this IEnumerable<Task<T>> source, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Sum(selector);
        }

        public static async Task<long> SumAsync<T>(this IEnumerable<Task<T>> source, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Sum(selector);
        }

        public static async Task<float> SumAsync<T>(this IEnumerable<Task<T>> source, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Sum(selector);
        }

        public static async Task<double> SumAsync<T>(this IEnumerable<Task<T>> source, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Sum(selector);
        }

        public static async Task<decimal> SumAsync<T>(this IEnumerable<Task<T>> source, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Sum(selector);
        }
    }
}
