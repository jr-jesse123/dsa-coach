# 24. Coin Change

- LeetCode #322 · Medium
- Implement `Solution.CoinChange` in `Solution.cs`, then run `P024_CoinChangeTests`.

## Problem

`coins` holds coin denominations and `amount` is a total. Return the fewest number of coins needed to make exactly
`amount`, or `-1` if it cannot be made. You have an unlimited supply of each coin.

## Examples

**Example 1**

```text
Input:  coins = [1,2,5], amount = 11
Output: 3
```

11 = 5 + 5 + 1.

**Example 2**

```text
Input:  coins = [2], amount = 3
Output: -1
```

**Example 3**

```text
Input:  coins = [1], amount = 0
Output: 0
```

## Constraints

- `1 <= coins.length <= 12`
- `1 <= coins[i] <= 2^31 - 1`
- `0 <= amount <= 10^4`

## Signature

```csharp
public int CoinChange(int[] coins, int amount)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P024_CoinChange"
```
