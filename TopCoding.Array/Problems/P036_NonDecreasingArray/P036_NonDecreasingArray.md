# 36. Non-decreasing Array

- LeetCode #665 · Medium
- Implement `Solution.CheckPossibility` in `Solution.cs`, then run `P036_NonDecreasingArrayTests`.

## Problem

Given an array `nums` of `n` integers, check whether it can become non-decreasing by modifying **at most one**
element. An array is non-decreasing if `nums[i] <= nums[i + 1]` for every `0 <= i <= n - 2`.

## Examples

**Example 1**

```text
Input:  nums = [4,2,3]
Output: true
```

**Example 2**

```text
Input:  nums = [4,2,1]
Output: false
```

## Constraints

- `n == nums.length`
- `1 <= n <= 10^4`
- `-10^5 <= nums[i] <= 10^5`

## Signature

```csharp
public bool CheckPossibility(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P036_NonDecreasingArray"
```
