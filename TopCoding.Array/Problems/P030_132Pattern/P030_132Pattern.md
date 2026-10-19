# 30. 132 Pattern

- LeetCode #456 · Medium
- Implement `Solution.Find132pattern` in `Solution.cs`, then run `P030_132PatternTests`.

## Problem

A 132 pattern is a subsequence `nums[i], nums[j], nums[k]` with `i < j < k` and `nums[i] < nums[k] < nums[j]`.
Return `true` if `nums` contains a 132 pattern, otherwise `false`.

## Examples

**Example 1**

```text
Input:  nums = [1,2,3,4]
Output: false
```

There is no 132 pattern.

**Example 2**

```text
Input:  nums = [3,1,4,2]
Output: true
```

The pattern [1, 4, 2] exists.

**Example 3**

```text
Input:  nums = [-1,3,2,0]
Output: true
```

The patterns [-1, 3, 2], [-1, 3, 0] and [-1, 2, 0] exist.

## Constraints

- `n == nums.length`
- `1 <= n <= 2 * 10^5`
- `-10^9 <= nums[i] <= 10^9`

## Signature

```csharp
public bool Find132pattern(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P030_132Pattern"
```
