# 23. Longest Increasing Subsequence

- LeetCode #300 · Medium
- Implement `Solution.LengthOfLIS` in `Solution.cs`, then run `P023_LongestIncreasingSubsequenceTests`.

## Problem

Given an integer array `nums`, return the length of the longest strictly increasing subsequence (elements keep their
relative order but need not be contiguous).

## Examples

**Example 1**

```text
Input:  nums = [10,9,2,5,3,7,101,18]
Output: 4
```

One longest increasing subsequence is [2,3,7,101].

**Example 2**

```text
Input:  nums = [0,1,0,3,2,3]
Output: 4
```

**Example 3**

```text
Input:  nums = [7,7,7,7,7,7,7]
Output: 1
```

## Constraints

- `1 <= nums.length <= 2500`
- `-10^4 <= nums[i] <= 10^4`

## Follow-up

Can you come up with an O(n log n) algorithm?

## Signature

```csharp
public int LengthOfLIS(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P023_LongestIncreasingSubsequence"
```
