# 28. Find All Duplicates in an Array

- LeetCode #442 · Medium
- Implement `Solution.FindDuplicates` in `Solution.cs`, then run `P028_FindAllDuplicatesInAnArrayTests`.

## Problem

`nums` has `n` integers in the range `[1, n]`, and each integer appears once or twice. Return an array of all the
integers that appear twice (in any order; the tests compare them sorted).

The algorithm must run in O(n) time and use only constant auxiliary space, excluding the space for the output.

## Examples

**Example 1**

```text
Input:  nums = [4,3,2,7,8,2,3,1]
Output: [2,3]
```

**Example 2**

```text
Input:  nums = [1,1,2]
Output: [1]
```

**Example 3**

```text
Input:  nums = [1]
Output: []
```

## Constraints

- `n == nums.length`
- `1 <= n <= 10^5`
- `1 <= nums[i] <= n`
- Each element appears once or twice

## Signature

```csharp
public int[] FindDuplicates(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P028_FindAllDuplicatesInAnArray"
```
