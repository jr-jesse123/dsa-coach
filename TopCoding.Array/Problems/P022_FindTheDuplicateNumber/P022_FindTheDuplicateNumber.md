# 22. Find the Duplicate Number

- LeetCode #287 · Medium
- Implement `Solution.FindDuplicate` in `Solution.cs`, then run `P022_FindTheDuplicateNumberTests`.

## Problem

`nums` has `n + 1` integers, each in the range `[1, n]`. Exactly one value is repeated (it may appear two or more
times); every other value appears once. Return the repeated value.

Do not modify `nums` and use only constant extra space.

## Examples

**Example 1**

```text
Input:  nums = [1,3,4,2,2]
Output: 2
```

**Example 2**

```text
Input:  nums = [3,1,3,4,2]
Output: 3
```

**Example 3**

```text
Input:  nums = [3,3,3,3,3]
Output: 3
```

## Constraints

- `1 <= n <= 10^5`
- `nums.length == n + 1`
- `1 <= nums[i] <= n`
- Exactly one integer appears two or more times; all others appear once

## Follow-up

How can you prove that at least one duplicate must exist? Can you solve it in linear runtime?

## Signature

```csharp
public int FindDuplicate(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P022_FindTheDuplicateNumber"
```
