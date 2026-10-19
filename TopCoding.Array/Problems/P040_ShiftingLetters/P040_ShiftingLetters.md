# 40. Shifting Letters

- LeetCode #848 · Medium
- Implement `Solution.ShiftingLetters` in `Solution.cs`, then run `P040_ShiftingLettersTests`.

## Problem

`s` is a lowercase string and `shifts` is an integer array of the same length. Shifting a letter moves it to the next
letter of the alphabet, wrapping `'z'` back to `'a'`.

For each `shifts[i] = x`, shift the first `i + 1` letters of `s`, `x` times. Return the resulting string after all shifts.

## Examples

**Example 1**

```text
Input:  s = "abc", shifts = [3,5,9]
Output: "rpl"
```

After shifting the first 1 letter by 3: "dbc". The first 2 letters by 5: "igc". The first 3 letters by 9: "rpl".

**Example 2**

```text
Input:  s = "aaa", shifts = [1,2,3]
Output: "gfd"
```

## Constraints

- `1 <= s.length <= 10^5`
- `s` consists of lowercase English letters
- `shifts.length == s.length`
- `0 <= shifts[i] <= 10^9`

## Signature

```csharp
public string ShiftingLetters(string s, int[] shifts)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P040_ShiftingLetters"
```
