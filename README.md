AsyncLinq
=========

A collection of extension methods providing support for TPL tasks in LINQ-to-Objects.
The package is distributed via source ([this repo](https://github.com/NeoLegends/AsyncLinq)) or via [NuGet](https://www.nuget.org/packages/NeoLegends.AsyncLinq/).

LINQ-Support (for struck-through see below):
- [X] Aggregate
- [X] All
- [X] Any
- [ ] ~~AsEnumerable~~
- [X] Average
- [X] Cast
- [X] Concat
- [X] Contains
- [X] Count
- [ ] ~~DefaultIfEmpty~~
- [X] Distinct
- [X] ElementAt
- [X] ElementAtOrDefault
- [X] Except
- [X] First
- [X] FirstOrDefault
- [X] GroupBy
- [X] GroupJoin
- [X] Intersect
- [X] Join
- [X] Last
- [X] LastOrDefault
- [X] LongCount
- [X] Max
- [X] Min
- [X] OfType
- [X] OrderBy
- [X] OrderByDescending
- [ ] ~~Range~~
- [ ] ~~Repeat~~
- [X] Reverse
- [X] Select
- [X] SelectMany
- [X] SequenceEqual
- [X] Single
- [X] SingleOrDefault
- [X] Skip
- [X] SkipWhile
- [X] Sum
- [X] Take
- [X] TakeWhile
- [X] ThenBy
- [X] ThenByDescending
- [X] ToArray
- [X] ToDictionary
- [X] ToList
- [X] ToLookup
- [X] Union
- [X] Where
- [X] Zip

Struck-through items do not make sense in combination with async. A .Skip-method does not need to wait for the tasks to complete to be able to skip a certain amount of items.
