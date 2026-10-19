# 11. Triangle

- LeetCode #120 · Medium
- Implement `Solution.MinimumTotal` in `Solution.cs`, then run `P011_TriangleTests`.

## Problem

Given a `triangle` (row `i` has `i + 1` numbers), return the minimum path sum from top to bottom. From index `j`
in the current row you may step to index `j` or `j + 1` in the row below.

In C# the triangle is passed as a jagged `int[][]`.

## Examples

**Example 1**

```text
Input:  triangle = [[2],[3,4],[6,5,7],[4,1,8,3]]
Output: 11
```

The path 2 -> 3 -> 5 -> 1 gives the minimum sum, 11.

**Example 2**

```text
Input:  triangle = [[-10]]
Output: -10
```

## Constraints

- `1 <= triangle.length <= 200`
- `triangle[0].length == 1`
- `triangle[i].length == triangle[i - 1].length + 1`
- `-10^4 <= triangle[i][j] <= 10^4`

## Follow-up

Can you do this using only O(n) extra space, where n is the number of rows?

## Signature

```csharp
public int MinimumTotal(int[][] triangle)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P011_Triangle"
```
