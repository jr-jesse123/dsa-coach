# 19. Kth Largest Element in an Array

- LeetCode #215 · Medium
- Implement `Solution.FindKthLargest` in `Solution.cs`, then run `P019_KthLargestElementInAnArrayTests`.

## Problem

Given an integer array `nums` and an integer `k`, return the `k`-th largest element in sorted order (not the k-th
distinct element). Try to solve it without fully sorting the array.

## Examples

**Example 1**

```text
Input:  nums = [3,2,1,5,6,4], k = 2
Output: 5
```

**Example 2**

```text
Input:  nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
```

## Constraints

- `1 <= k <= nums.length <= 10^5`
- `-10^4 <= nums[i] <= 10^4`

## Signature

```csharp
public int FindKthLargest(int[] nums, int k)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P019_KthLargestElementInAnArray"
```
