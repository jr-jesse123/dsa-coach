# 37. Subarray Product Less Than K

- LeetCode #713 · Medium
- Implement `Solution.NumSubarrayProductLessThanK` in `Solution.cs`, then run `P037_SubarrayProductLessThanKTests`.

## Problem

Given an array of integers `nums` and an integer `k`, return the number of contiguous subarrays whose product is
**strictly** less than `k`.

## Examples

**Example 1**

```text
Input:  nums = [10,5,2,6], k = 100
Output: 8
```

The subarrays are [10], [5], [2], [6], [10,5], [5,2], [2,6] and [5,2,6]. [10,5,2] is not counted because its product is 100, not strictly less than 100.

**Example 2**

```text
Input:  nums = [1,2,3], k = 0
Output: 0
```

## Constraints

- `1 <= nums.length <= 3 * 10^4`
- `1 <= nums[i] <= 1000`
- `0 <= k <= 10^6`

## Signature

```csharp
public int NumSubarrayProductLessThanK(int[] nums, int k)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P037_SubarrayProductLessThanK"
```
