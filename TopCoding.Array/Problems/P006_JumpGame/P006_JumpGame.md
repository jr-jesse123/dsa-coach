# 6. Jump Game

- LeetCode #55 · Medium
- Implement `Solution.CanJump` in `Solution.cs`, then run `P006_JumpGameTests`.

## Problem

You start at the first index of `nums`. Each element is the maximum jump length from that position.
Return `true` if you can reach the last index, otherwise `false`.

## Examples

**Example 1**

```text
Input:  nums = [2,3,1,1,4]
Output: true
```

Jump 1 step from index 0 to 1, then 3 steps to the last index.

**Example 2**

```text
Input:  nums = [3,2,1,0,4]
Output: false
```

You always end up at index 3, whose maximum jump length is 0, so the last index is unreachable.

## Constraints

- `1 <= nums.length <= 10^4`
- `0 <= nums[i] <= 10^5`

## Signature

```csharp
public bool CanJump(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P006_JumpGame"
```
