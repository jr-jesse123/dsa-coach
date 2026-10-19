# 47. Count Subarrays Where Max Element Appears at Least K Times

- LeetCode #2962 · Medium
- Implement `Solution.CountSubarrays` in `Solution.cs`, then run `P047_CountSubarraysWhereMaxElementAppearsAtLeastKTimesTests`.

## Problem

Given an integer array `nums` and a positive integer `k`, return the number of subarrays in which the maximum element of
`nums` (the global maximum) appears at least `k` times. A subarray is a contiguous sequence of elements.

The result can exceed the 32-bit range, so the C# method returns `long`.

## Examples

**Example 1**

```text
Input:  nums = [1,3,2,3,3], k = 2
Output: 6
```

The qualifying subarrays are [1,3,2,3], [1,3,2,3,3], [3,2,3], [3,2,3,3], [2,3,3] and [3,3].

**Example 2**

```text
Input:  nums = [1,4,2,1], k = 3
Output: 0
```

## Constraints

- `1 <= nums.length <= 10^5`
- `1 <= nums[i] <= 10^6`
- `1 <= k <= 10^5`

## Signature

```csharp
public long CountSubarrays(int[] nums, int k)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P047_CountSubarraysWhereMaxElementAppearsAtLeastKTimes"
```
