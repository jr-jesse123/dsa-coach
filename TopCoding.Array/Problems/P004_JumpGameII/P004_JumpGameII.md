# 4. Jump Game II

- LeetCode #45 · Medium
- Implement `Solution.Jump` in `Solution.cs`, then run `P004_JumpGameIITests`.

## Problem

You start at index 0 of a 0-indexed array `nums`. `nums[i]` is the maximum forward jump length from index `i`:
from `i` you can land on any index `i + j` with `0 <= j <= nums[i]` and `i + j < n`.

Return the minimum number of jumps needed to reach index `n - 1`. The test cases guarantee it is reachable.

## Examples

**Example 1**

```text
Input:  nums = [2,3,1,1,4]
Output: 2
```

Jump 1 step from index 0 to 1, then 3 steps to the last index.

**Example 2**

```text
Input:  nums = [2,3,0,1,4]
Output: 2
```

## Constraints

- `1 <= nums.length <= 10^4`
- `0 <= nums[i] <= 1000`
- It is guaranteed that you can reach `nums[n - 1]`

## Signature

```csharp
public int Jump(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P004_JumpGameII"
```
