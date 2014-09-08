﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public static class AsyncElementAt
    {
        public static async Task<T> ElementAtAsync<T>(this Task<IEnumerable<T>> collection, int index)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentOutOfRangeException>(index >= 0);

            return (await collection).ElementAt(index);
        }
        
        public static async Task<T> ElementAtAsync<T>(this IEnumerable<Task<T>> collection, int index)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentOutOfRangeException>(index >= 0);

            return (await Task.WhenAll(collection)).ElementAt(index);
        }
    }
}