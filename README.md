AsyncLinq
=========

A collection of extension methods providing support for TPL tasks in LINQ-to-Objects.
The package is distributed via source ([this repo](https://github.com/NeoLegends/AsyncLinq)) or via [NuGet](https://www.nuget.org/packages/NeoLegends.AsyncLinq/).

AsyncLinq is built to enable almost seamless interaction of TPL and LINQ queries. It does so by providing extension methods to Task<IEnumerable<T>> and IEnumerable<Task<T>> that use the same syntax as the regular LINQ query operators. It also provides a fluent interface just like the regular LINQ so you'll only need to use one and only one await - for the results of your query.

For more information, see the  [wiki](https://github.com/NeoLegends/AsyncLinq/wiki).
