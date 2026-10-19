# 12. Longest Consecutive Sequence

- LeetCode #128 · Medium
- Implement `Solution.LongestConsecutive` in `Solution.cs`, then run `P012_LongestConsecutiveSequenceTests`.

## Problem

Given an unsorted integer array `nums`, return the length of the longest sequence of consecutive integers
(for example `1, 2, 3, 4`) that can be formed from its elements. The elements do not have to be adjacent in the array.

The algorithm must run in O(n) time.

## Examples

**Example 1**

```text
Input:  nums = [100,4,200,1,3,2]
Output: 4
```

The longest consecutive sequence is [1, 2, 3, 4], so the length is 4.

**Example 2**

```text
Input:  nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
```

## Constraints

- `0 <= nums.length <= 10^5`
- `-10^9 <= nums[i] <= 10^9`

## Signature

```csharp
public int LongestConsecutive(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P012_LongestConsecutiveSequence"
```
