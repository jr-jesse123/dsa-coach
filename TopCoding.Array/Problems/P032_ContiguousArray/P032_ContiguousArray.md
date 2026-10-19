# 32. Contiguous Array

- LeetCode #525 · Medium
- Implement `Solution.FindMaxLength` in `Solution.cs`, then run `P032_ContiguousArrayTests`.

## Problem

Given a binary array `nums`, return the length of the longest contiguous subarray that contains an equal number of
`0` and `1`.

## Examples

**Example 1**

```text
Input:  nums = [0,1]
Output: 2
```

[0, 1] is the longest contiguous subarray with equal numbers of 0 and 1.

**Example 2**

```text
Input:  nums = [0,1,0]
Output: 2
```

[0, 1] and [1, 0] both qualify.

**Example 3**

```text
Input:  nums = [0,1,1,1,1,1,0,0,0]
Output: 6
```

[1,1,1,0,0,0] has three 1s and three 0s.

## Constraints

- `1 <= nums.length <= 10^5`
- `nums[i]` is `0` or `1`

## Signature

```csharp
public int FindMaxLength(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P032_ContiguousArray"
```
