# 31. Target Sum

- LeetCode #494 · Medium
- Implement `Solution.FindTargetSumWays` in `Solution.cs`, then run `P031_TargetSumTests`.

## Problem

Put a `+` or `-` in front of every integer in `nums` and concatenate the results into an expression. Return the number of
different ways to build an expression that evaluates to `target`.

## Examples

**Example 1**

```text
Input:  nums = [1,1,1,1,1], target = 3
Output: 5
```

There are 5 ways, e.g. -1+1+1+1+1 = 3 (the minus can be on any of the five numbers).

**Example 2**

```text
Input:  nums = [1], target = 1
Output: 1
```

## Constraints

- `1 <= nums.length <= 20`
- `0 <= nums[i] <= 1000`
- `0 <= sum(nums[i]) <= 1000`
- `-1000 <= target <= 1000`

## Signature

```csharp
public int FindTargetSumWays(int[] nums, int target)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P031_TargetSum"
```
