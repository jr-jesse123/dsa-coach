# 42. Minimum Increment to Make Array Unique

- LeetCode #945 · Medium
- Implement `Solution.MinIncrementForUnique` in `Solution.cs`, then run `P042_MinimumIncrementToMakeArrayUniqueTests`.

## Problem

In one move you may pick any index `i` and increment `nums[i]` by 1. Return the minimum number of moves needed to make
every value in `nums` unique. The test cases guarantee the answer fits in a 32-bit integer.

## Examples

**Example 1**

```text
Input:  nums = [1,2,2]
Output: 1
```

After one move, nums becomes [1, 2, 3].

**Example 2**

```text
Input:  nums = [3,2,1,2,1,7]
Output: 6
```

After 6 moves nums can be [3, 4, 1, 2, 5, 7]; fewer than 6 moves cannot make all values unique.

## Constraints

- `1 <= nums.length <= 10^5`
- `0 <= nums[i] <= 10^5`

## Signature

```csharp
public int MinIncrementForUnique(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P042_MinimumIncrementToMakeArrayUnique"
```
