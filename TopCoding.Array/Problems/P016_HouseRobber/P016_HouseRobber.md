# 16. House Robber

- LeetCode #198 · Medium
- Implement `Solution.Rob` in `Solution.cs`, then run `P016_HouseRobberTests`.

## Problem

You are robbing houses along a street. `nums[i]` is the money in house `i`, but adjacent houses have linked alarms:
robbing two adjacent houses on the same night alerts the police. Return the maximum amount you can rob without
robbing two adjacent houses.

## Examples

**Example 1**

```text
Input:  nums = [1,2,3,1]
Output: 4
```

Rob house 1 (1) and house 3 (3): 1 + 3 = 4.

**Example 2**

```text
Input:  nums = [2,7,9,3,1]
Output: 12
```

Rob houses 1, 3 and 5: 2 + 9 + 1 = 12.

## Constraints

- `1 <= nums.length <= 100`
- `0 <= nums[i] <= 400`

## Signature

```csharp
public int Rob(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P016_HouseRobber"
```
