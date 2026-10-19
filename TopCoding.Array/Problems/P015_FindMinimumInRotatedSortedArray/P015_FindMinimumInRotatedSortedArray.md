# 15. Find Minimum in Rotated Sorted Array

- LeetCode #153 · Medium
- Implement `Solution.FindMin` in `Solution.cs`, then run `P015_FindMinimumInRotatedSortedArrayTests`.

## Problem

An array of `n` unique elements sorted in ascending order has been rotated between 1 and `n` times. Rotating once moves
the last element to the front, so `[0,1,2,4,5,6,7]` rotated 4 times becomes `[4,5,6,7,0,1,2]`, and rotating it 7 times gives
the original array back.

Given the rotated array, return its minimum element. The algorithm must run in O(log n).

## Examples

**Example 1**

```text
Input:  nums = [3,4,5,1,2]
Output: 1
```

The original array was [1,2,3,4,5] rotated 3 times.

**Example 2**

```text
Input:  nums = [4,5,6,7,0,1,2]
Output: 0
```

The original array was [0,1,2,4,5,6,7] rotated 4 times.

**Example 3**

```text
Input:  nums = [11,13,15,17]
Output: 11
```

The original array was [11,13,15,17] rotated 4 times.

## Constraints

- `n == nums.length`
- `1 <= n <= 5000`
- `-5000 <= nums[i] <= 5000`
- All integers of `nums` are unique
- `nums` is sorted and rotated between 1 and n times

## Signature

```csharp
public int FindMin(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P015_FindMinimumInRotatedSortedArray"
```
