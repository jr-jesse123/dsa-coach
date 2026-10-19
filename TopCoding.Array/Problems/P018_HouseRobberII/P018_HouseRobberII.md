# 18. House Robber II

- LeetCode #213 · Medium
- Implement `Solution.Rob` in `Solution.cs`, then run `P018_HouseRobberIITests`.

## Problem

Same as House Robber, but the houses are arranged in a circle: the first and the last house are neighbours.
Robbing two adjacent houses (including first + last) alerts the police. Return the maximum amount you can rob.

## Examples

**Example 1**

```text
Input:  nums = [2,3,2]
Output: 3
```

You cannot rob house 1 (2) and house 3 (2) because they are adjacent.

**Example 2**

```text
Input:  nums = [1,2,3,1]
Output: 4
```

Rob house 1 (1) and house 3 (3): 1 + 3 = 4.

**Example 3**

```text
Input:  nums = [1,2,3]
Output: 3
```

## Constraints

- `1 <= nums.length <= 100`
- `0 <= nums[i] <= 1000`

## Signature

```csharp
public int Rob(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P018_HouseRobberII"
```
