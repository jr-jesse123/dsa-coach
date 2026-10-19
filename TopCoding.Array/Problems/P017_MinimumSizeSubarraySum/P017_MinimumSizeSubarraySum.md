# 17. Minimum Size Subarray Sum

- LeetCode #209 · Medium
- Implement `Solution.MinSubArrayLen` in `Solution.cs`, then run `P017_MinimumSizeSubarraySumTests`.

## Problem

Given an array of positive integers `nums` and a positive integer `target`, return the minimal length of a contiguous
subarray whose sum is greater than or equal to `target`. If no such subarray exists, return `0`.

## Examples

**Example 1**

```text
Input:  target = 7, nums = [2,3,1,2,4,3]
Output: 2
```

The subarray [4,3] has the minimal length under the constraint.

**Example 2**

```text
Input:  target = 4, nums = [1,4,4]
Output: 1
```

**Example 3**

```text
Input:  target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0
```

## Constraints

- `1 <= target <= 10^9`
- `1 <= nums.length <= 10^5`
- `1 <= nums[i] <= 10^4`

## Follow-up

If you have found an O(n) solution, try coding an O(n log n) one as well.

## Signature

```csharp
public int MinSubArrayLen(int target, int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P017_MinimumSizeSubarraySum"
```
