# 7. Merge Intervals

- LeetCode #56 · Medium
- Implement `Solution.Merge` in `Solution.cs`, then run `P007_MergeIntervalsTests`.

## Problem

`intervals[i] = [start_i, end_i]`. Merge every group of overlapping intervals and return the resulting
non-overlapping intervals that cover exactly the same ranges. Intervals that only touch (e.g. `[1,4]` and `[4,5]`)
count as overlapping. The result may be in any order; the tests compare it sorted by start.

## Examples

**Example 1**

```text
Input:  intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
```

Intervals [1,3] and [2,6] overlap, so they become [1,6].

**Example 2**

```text
Input:  intervals = [[1,4],[4,5]]
Output: [[1,5]]
```

Intervals [1,4] and [4,5] are considered overlapping.

## Constraints

- `1 <= intervals.length <= 10^4`
- `intervals[i].length == 2`
- `0 <= start_i <= end_i <= 10^4`

## Signature

```csharp
public int[][] Merge(int[][] intervals)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P007_MergeIntervals"
```
