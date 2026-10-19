# 44. Find the Winner of an Array Game

- LeetCode #1535 · Medium
- Implement `Solution.GetWinner` in `Solution.cs`, then run `P044_FindTheWinnerOfAnArrayGameTests`.

## Problem

`arr` holds distinct integers. A game is played between `arr[0]` and `arr[1]`: in each round the larger value stays at
position 0 and the smaller one moves to the end of the array. The game ends when some value wins `k` consecutive rounds.
Return the value that wins the game (a winner is guaranteed).

## Examples

**Example 1**

```text
Input:  arr = [2,1,3,5,4,6,7], k = 2
Output: 5
```

Round 1: 2 beats 1. Round 2: 3 beats 2. Round 3: 5 beats 3. Round 4: 5 beats 4, its second win in a row, so 5 wins.

**Example 2**

```text
Input:  arr = [3,2,1], k = 10
Output: 3
```

## Constraints

- `2 <= arr.length <= 10^5`
- `1 <= arr[i] <= 10^6`
- `arr` contains distinct integers
- `1 <= k <= 10^9`

## Signature

```csharp
public int GetWinner(int[] arr, int k)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P044_FindTheWinnerOfAnArrayGame"
```
