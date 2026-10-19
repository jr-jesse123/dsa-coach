# 35. Subarray Sum Equals K

- LeetCode #560 · Medium
- Implement `Solution.SubarraySum` in `Solution.cs`, then run `P035_SubarraySumEqualsKTests`.

## Problem

Given an integer array `nums` and an integer `k`, return the total number of contiguous non-empty subarrays whose sum
equals `k`.

## Examples

**Example 1**

```text
Input:  nums = [1,1,1], k = 2
Output: 2
```

**Example 2**

```text
Input:  nums = [1,2,3], k = 3
Output: 2
```

## Constraints

- `1 <= nums.length <= 2 * 10^4`
- `-1000 <= nums[i] <= 1000`
- `-10^7 <= k <= 10^7`

## Signature

```csharp
public int SubarraySum(int[] nums, int k)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P035_SubarraySumEqualsK"
```
