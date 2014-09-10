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
        public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
            this Task<IEnumerable<TOuter>> outer,
            Task<IEnumerable<TInner>> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(outer != null);
            Contract.Requires<ArgumentNullException>(inner != null);
            Contract.Requires<ArgumentNullException>(outerKeySelector != null);
            Contract.Requires<ArgumentNullException>(innerKeySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await outer.ConfigureAwait(false)).GroupJoin(await inner.ConfigureAwait(false), outerKeySelector, innerKeySelector, resultSelector);
        }

        public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
            this IEnumerable<Task<TOuter>> outer,
            IEnumerable<Task<TInner>> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
            Contract.Requires<ArgumentNullException>(outer != null);
            Contract.Requires<ArgumentNullException>(inner != null);
            Contract.Requires<ArgumentNullException>(outerKeySelector != null);
            Contract.Requires<ArgumentNullException>(innerKeySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);

            return (await Task.WhenAll(outer).ConfigureAwait(false)).GroupJoin(await Task.WhenAll(inner).ConfigureAwait(false), outerKeySelector, innerKeySelector, resultSelector);
        }

        public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
            this Task<IEnumerable<TOuter>> outer,
            Task<IEnumerable<TInner>> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(outer != null);
            Contract.Requires<ArgumentNullException>(inner != null);
            Contract.Requires<ArgumentNullException>(outerKeySelector != null);
            Contract.Requires<ArgumentNullException>(innerKeySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await outer.ConfigureAwait(false)).GroupJoin(await inner.ConfigureAwait(false), outerKeySelector, innerKeySelector, resultSelector, keyComparer);
        }

        public static async Task<IEnumerable<TResult>> GroupJoinAsync<TOuter, TInner, TKey, TResult>(
            this IEnumerable<Task<TOuter>> outer,
            IEnumerable<Task<TInner>> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
            IEqualityComparer<TKey> keyComparer)
        {
            Contract.Requires<ArgumentNullException>(outer != null);
            Contract.Requires<ArgumentNullException>(inner != null);
            Contract.Requires<ArgumentNullException>(outerKeySelector != null);
            Contract.Requires<ArgumentNullException>(innerKeySelector != null);
            Contract.Requires<ArgumentNullException>(resultSelector != null);
            Contract.Requires<ArgumentNullException>(keyComparer != null);

            return (await Task.WhenAll(outer).ConfigureAwait(false)).GroupJoin(await Task.WhenAll(inner).ConfigureAwait(false), outerKeySelector, innerKeySelector, resultSelector, keyComparer);
        }
    }
}
