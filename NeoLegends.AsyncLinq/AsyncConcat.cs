using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static partial class AsyncEnumerable
    {
        public static async Task<IEnumerable<T>> ConcatAsync<T>(this Task<IEnumerable<T>> first, Task<IEnumerable<T>> second)
        {
            IEnumerable<T>[] whenAllResults = await Task.WhenAll(first, second);
            return whenAllResults[0].Concat(whenAllResults[1]);
        }

        public static async Task<IEnumerable<T>> ConcatAsync<T>(this IEnumerable<Task<T>> first, IEnumerable<Task<T>> second)
        {
            T[][] whenAllResults = await Task.WhenAll(Task.WhenAll(first), Task.WhenAll(second));
            return whenAllResults[0].Concat(whenAllResults[1]);
        }
    }
}
