using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncConcat
    {
        public static async Task<IEnumerable<T>> Concat<T>(this IEnumerable<Task<T>> first, IEnumerable<Task<T>> second)
        {
            T[][] whenAllResults = await Task.WhenAll(Task.WhenAll(first), Task.WhenAll(second));
            return whenAllResults[0].Concat(whenAllResults[1]);
        }
    }
}
