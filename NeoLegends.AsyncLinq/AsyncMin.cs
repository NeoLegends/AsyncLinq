using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncMax
    {
        public static async Task<int> MaxAsync(IEnumerable<Task<int>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Min();
        }

        public static async Task<long> MaxAsync(IEnumerable<Task<long>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Min();
        }

        public static async Task<float> MaxAsync(IEnumerable<Task<float>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Min();
        }

        public static async Task<double> MaxAsync(IEnumerable<Task<double>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Min();
        }

        public static async Task<decimal> MaxAsync(IEnumerable<Task<decimal>> source)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            return (await Task.WhenAll(source)).Min();
        }

        public static async Task<int> MaxAsync<T>(this IEnumerable<Task<T>> source, Func<T, int> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Min(selector);
        }

        public static async Task<long> MaxAsync<T>(this IEnumerable<Task<T>> source, Func<T, long> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Min(selector);
        }

        public static async Task<float> MaxAsync<T>(this IEnumerable<Task<T>> source, Func<T, float> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Min(selector);
        }

        public static async Task<double> MaxAsync<T>(this IEnumerable<Task<T>> source, Func<T, double> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Min(selector);
        }

        public static async Task<decimal> MaxAsync<T>(this IEnumerable<Task<T>> source, Func<T, decimal> selector)
        {
            Contract.Requires<ArgumentNullException>(source != null);
            Contract.Requires<ArgumentNullException>(selector != null);

            return (await Task.WhenAll(source)).Min(selector);
        }
    }
}
