# 33. Optimal Division

- LeetCode #553 · Medium
- Implement `Solution.OptimalDivision` in `Solution.cs`, then run `P033_OptimalDivisionTests`.

## Problem

`nums` is divided left to right using float division: `nums[0] / nums[1] / ... / nums[n-1]`. You may add parentheses
anywhere to change the order of operations. Return the expression, as a string, that produces the maximum value.

The expression must not contain redundant parentheses.

## Examples

**Example 1**

```text
Input:  nums = [1000,100,10,2]
Output: "1000/(100/10/2)"
```

1000/(100/10/2) = 1000/((100/10)/2) = 200. Other parenthesisations give smaller values, and wrapping single operands in extra parentheses would be redundant.

**Example 2**

```text
Input:  nums = [2,3,4]
Output: "2/(3/4)"
```

2/(3/4) = 8/3 is the largest possible value.

## Constraints

- `1 <= nums.length <= 10`
- `2 <= nums[i] <= 1000`
- There is only one optimal division for the given input

## Signature

```csharp
public string OptimalDivision(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P033_OptimalDivision"
```
