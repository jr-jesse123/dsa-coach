# 2. Search in Rotated Sorted Array

- LeetCode #33 · Medium
- Implement `Solution.Search` in `Solution.cs`, then run `P002_SearchInRotatedSortedArrayTests`.

## Problem

`nums` was sorted in ascending order with distinct values, then rotated at some unknown pivot `k`
(`1 <= k < nums.length`), so it became `[nums[k], ..., nums[n-1], nums[0], ..., nums[k-1]]`.
For example `[0,1,2,4,5,6,7]` rotated at pivot 3 becomes `[4,5,6,7,0,1,2]`.

Given the rotated array and an integer `target`, return the index of `target`, or `-1` if it is not present.
The algorithm must run in O(log n).

## Examples

**Example 1**

```text
Input:  nums = [4,5,6,7,0,1,2], target = 0
Output: 4
```

**Example 2**

```text
Input:  nums = [4,5,6,7,0,1,2], target = 3
Output: -1
```

**Example 3**

```text
Input:  nums = [1], target = 0
Output: -1
```

## Constraints

- `1 <= nums.length <= 5000`
- `-10^4 <= nums[i] <= 10^4`
- All values of `nums` are unique
- `nums` is an ascending array that is possibly rotated
- `-10^4 <= target <= 10^4`

## Signature

```csharp
public int Search(int[] nums, int target)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P002_SearchInRotatedSortedArray"
```
