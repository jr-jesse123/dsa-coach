# 21. H-Index

- LeetCode #274 · Medium
- Implement `Solution.HIndex` in `Solution.cs`, then run `P021_HIndexTests`.

## Problem

`citations[i]` is the number of citations of the researcher's i-th paper. Return the researcher's h-index: the largest
`h` such that the researcher has at least `h` papers with at least `h` citations each.

## Examples

**Example 1**

```text
Input:  citations = [3,0,6,1,5]
Output: 3
```

There are 5 papers. Three of them have at least 3 citations each and the other two have no more than 3, so h = 3.

**Example 2**

```text
Input:  citations = [1,3,1]
Output: 1
```

## Constraints

- `n == citations.length`
- `1 <= n <= 5000`
- `0 <= citations[i] <= 1000`

## Signature

```csharp
public int HIndex(int[] citations)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P021_HIndex"
```
