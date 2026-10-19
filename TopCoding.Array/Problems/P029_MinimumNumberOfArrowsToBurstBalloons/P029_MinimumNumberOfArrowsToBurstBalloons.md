# 29. Minimum Number of Arrows to Burst Balloons

- LeetCode #452 · Medium
- Implement `Solution.FindMinArrowShots` in `Solution.cs`, then run `P029_MinimumNumberOfArrowsToBurstBalloonsTests`.

## Problem

Balloons are taped to a wall. `points[i] = [x_start, x_end]` is the horizontal span of balloon `i` (the y-coordinates do
not matter). An arrow shot straight up from x bursts every balloon with `x_start <= x <= x_end` and keeps going.

Return the minimum number of arrows needed to burst all balloons.

## Examples

**Example 1**

```text
Input:  points = [[10,16],[2,8],[1,6],[7,12]]
Output: 2
```

Shoot at x = 6 (bursts [2,8] and [1,6]) and at x = 11 (bursts [10,16] and [7,12]).

**Example 2**

```text
Input:  points = [[1,2],[3,4],[5,6],[7,8]]
Output: 4
```

No balloons overlap, so one arrow per balloon.

**Example 3**

```text
Input:  points = [[1,2],[2,3],[3,4],[4,5]]
Output: 2
```

Shoot at x = 2 and at x = 4.

## Constraints

- `1 <= points.length <= 10^5`
- `points[i].length == 2`
- `-2^31 <= x_start < x_end <= 2^31 - 1`

## Signature

```csharp
public int FindMinArrowShots(int[][] points)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P029_MinimumNumberOfArrowsToBurstBalloons"
```
