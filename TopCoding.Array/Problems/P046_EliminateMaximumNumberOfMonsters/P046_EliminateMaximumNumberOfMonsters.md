# 46. Eliminate Maximum Number of Monsters

- LeetCode #1921 · Medium
- Implement `Solution.EliminateMaximum` in `Solution.cs`, then run `P046_EliminateMaximumNumberOfMonstersTests`.

## Problem

`n` monsters walk toward your city. `dist[i]` is the initial distance (km) of monster `i` and `speed[i]` its speed
(km/minute). Your weapon kills one monster per shot, takes one minute to charge, and is fully charged at minute 0.

You lose as soon as any monster reaches the city. If one arrives at the exact moment the weapon finishes charging, that
counts as a loss before you can fire. Return the maximum number of monsters you can eliminate before losing, or `n` if
you can eliminate them all.

## Examples

**Example 1**

```text
Input:  dist = [1,3,4], speed = [1,1,1]
Output: 3
```

Kill the first monster, then the second after one minute, then the third after another minute.

**Example 2**

```text
Input:  dist = [1,1,2,3], speed = [1,1,1,1]
Output: 1
```

After the first kill and one minute, the second monster reaches the city, so you lose.

**Example 3**

```text
Input:  dist = [3,2,4], speed = [5,3,2]
Output: 1
```

After the first kill and one minute, the second monster reaches the city, so you lose.

## Constraints

- `n == dist.length == speed.length`
- `1 <= n <= 10^5`
- `1 <= dist[i], speed[i] <= 10^5`

## Signature

```csharp
public int EliminateMaximum(int[] dist, int[] speed)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P046_EliminateMaximumNumberOfMonsters"
```
