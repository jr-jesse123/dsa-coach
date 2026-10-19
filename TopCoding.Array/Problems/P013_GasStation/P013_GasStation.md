# 13. Gas Station

- LeetCode #134 · Medium
- Implement `Solution.CanCompleteCircuit` in `Solution.cs`, then run `P013_GasStationTests`.

## Problem

There are `n` gas stations on a circular route; station `i` has `gas[i]` units of gas. Driving from station `i`
to station `i + 1` costs `cost[i]` units. Your tank is unlimited but starts empty, and you start at one of the stations
(filling up there).

Return the index of the station from which you can complete the full circuit clockwise, or `-1` if it is impossible.
If a solution exists, it is guaranteed to be unique.

## Examples

**Example 1**

```text
Input:  gas = [1,2,3,4,5], cost = [3,4,5,1,2]
Output: 3
```

Start at station 3 (tank 4), then 4 (tank 8), 0 (7), 1 (6), 2 (5) and finally back at 3. The loop completes.

**Example 2**

```text
Input:  gas = [2,3,4], cost = [3,4,3]
Output: -1
```

You cannot start at station 0 or 1 (not enough gas for the next leg). Starting at 2 you run out before getting back to 2.

## Constraints

- `n == gas.length == cost.length`
- `1 <= n <= 10^5`
- `0 <= gas[i], cost[i] <= 10^4`

## Signature

```csharp
public int CanCompleteCircuit(int[] gas, int[] cost)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P013_GasStation"
```
