# 43. Max Consecutive Ones III

- LeetCode #1004 · Medium
- Implement `Solution.LongestOnes` in `Solution.cs`, then run `P043_MaxConsecutiveOnesIIITests`.

## Problem

Given a binary array `nums` and an integer `k`, return the maximum number of consecutive `1`s in the array if you can flip
at most `k` zeros to ones.

## Examples

**Example 1**

```text
Input:  nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
Output: 6
```

Flipping two of the zeros gives a run of six 1s.

**Example 2**

```text
Input:  nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
Output: 10
```

Flipping three zeros gives a run of ten 1s.

## Constraints

- `1 <= nums.length <= 10^5`
- `nums[i]` is `0` or `1`
- `0 <= k <= nums.length`

## Signature

```csharp
public int LongestOnes(int[] nums, int k)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P043_MaxConsecutiveOnesIII"
```
