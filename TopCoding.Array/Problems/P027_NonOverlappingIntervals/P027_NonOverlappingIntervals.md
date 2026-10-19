# 27. Non-overlapping Intervals

- LeetCode #435 · Medium
- Implement `Solution.EraseOverlapIntervals` in `Solution.cs`, then run `P027_NonOverlappingIntervalsTests`.

## Problem

`intervals[i] = [start_i, end_i]`. Return the minimum number of intervals to remove so that the remaining intervals do not
overlap. Intervals that only touch at an endpoint (e.g. `[1,2]` and `[2,3]`) do not overlap.

## Examples

**Example 1**

```text
Input:  intervals = [[1,2],[2,3],[3,4],[1,3]]
Output: 1
```

Removing [1,3] makes the rest non-overlapping.

**Example 2**

```text
Input:  intervals = [[1,2],[1,2],[1,2]]
Output: 2
```

You must remove two of the three identical intervals.

**Example 3**

```text
Input:  intervals = [[1,2],[2,3]]
Output: 0
```

Nothing to remove; the intervals only touch.

## Constraints

- `1 <= intervals.length <= 10^5`
- `intervals[i].length == 2`
- `-5 * 10^4 <= start_i < end_i <= 5 * 10^4`

## Signature

```csharp
public int EraseOverlapIntervals(int[][] intervals)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P027_NonOverlappingIntervals"
```
