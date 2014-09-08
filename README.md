AsyncLinq
=========

A collection of extension methods providing support for TPL tasks in LINQ-to-Objects.

LINQ-Support (for struck-through see below):
- [X] Aggregate
- [X] All
- [X] Any
- [ ] ~~AsEnumerable~~
- [X] Average
- [X] Cast
- [X] Concat
- [X] Contains
- [ ] Count
- [ ] ~~DefaultIfEmpty~~
- [X] Distinct
- [X] ElementAt
- [X] ElementAtOrDefault
- [X] Except
- [X] First
- [X] FirstOrDefault
- [X] GroupBy
- [ ] GroupJoin
- [X] Intersect
- [ ] Join
- [X] Last
- [X] LastOrDefault
- [ ] LongCount
- [X] Max
- [X] Min
- [X] OfType
- [X] OrderBy
- [X] OrderByDescending
- [ ] ~~Range~~
- [ ] ~~Repeat~~
- [ ] Reverse
- [X] Select
- [X] SelectMany
- [X] SequenceEqual
- [ ] Single
- [ ] SingleOrDefault
- [ ] ~~Skip~~
- [ ] SkipWhile
- [X] Sum
- [ ] ~~Take~~
- [ ] TakeWhile
- [ ] ThenBy
- [ ] ThenByDescending
- [X] ToArray
- [X] ToDictionary
- [X] ToList
- [ ] ToLookup
- [X] Union
- [X] Where
- [X] Zip

Struck-through items do not make sense in combination with async. A .Skip-method does not need to wait for the tasks to complete to be able to skip a certain amount of items.
