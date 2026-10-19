# 14. Maximum Product Subarray

- LeetCode #152 · Medium
- Implement `Solution.MaxProduct` in `Solution.cs`, then run `P014_MaximumProductSubarrayTests`.

## Problem

Given an integer array `nums`, find the contiguous non-empty subarray with the largest product and return that product.
The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

## Examples

**Example 1**

```text
Input:  nums = [2,3,-2,4]
Output: 6
```

The subarray [2,3] has the largest product, 6.

**Example 2**

```text
Input:  nums = [-2,0,-1]
Output: 0
```

The result cannot be 2 because [-2,-1] is not a subarray.

## Constraints

- `1 <= nums.length <= 2 * 10^4`
- `-10 <= nums[i] <= 10`
- The product of any prefix or suffix of `nums` fits in a 32-bit integer

## Signature

```csharp
public int MaxProduct(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P014_MaximumProductSubarray"
```
