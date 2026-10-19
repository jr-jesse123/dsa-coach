# 5. Maximum Subarray

- LeetCode #53 · Medium
- Implement `Solution.MaxSubArray` in `Solution.cs`, then run `P005_MaximumSubarrayTests`.

## Problem

Given an integer array `nums`, find the contiguous non-empty subarray with the largest sum and return that sum.

## Examples

**Example 1**

```text
Input:  nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
```

The subarray [4,-1,2,1] has the largest sum, 6.

**Example 2**

```text
Input:  nums = [1]
Output: 1
```

The subarray [1] has the largest sum, 1.

**Example 3**

```text
Input:  nums = [5,4,-1,7,8]
Output: 23
```

The whole array has the largest sum, 23.

## Constraints

- `1 <= nums.length <= 10^5`
- `-10^4 <= nums[i] <= 10^4`

## Follow-up

If you have found the O(n) solution, try the divide and conquer approach as well.

## Signature

```csharp
public int MaxSubArray(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P005_MaximumSubarray"
```
