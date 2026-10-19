# 26. UTF-8 Validation

- LeetCode #393 · Medium
- Implement `Solution.ValidUtf8` in `Solution.cs`, then run `P026_UTF8ValidationTests`.

## Problem

Given an integer array `data` where each element holds one byte (only the least significant 8 bits count), return whether
it is a valid UTF-8 encoding. A character takes 1 to 4 bytes:

```text
1 byte : 0xxxxxxx
2 bytes: 110xxxxx 10xxxxxx
3 bytes: 1110xxxx 10xxxxxx 10xxxxxx
4 bytes: 11110xxx 10xxxxxx 10xxxxxx 10xxxxxx
```

`x` is any bit. For an n-byte character, the first byte starts with n ones followed by a zero and the next n - 1 bytes
start with `10`.

## Examples

**Example 1**

```text
Input:  data = [197,130,1]
Output: true
```

The bytes 11000101 10000010 00000001 are a 2-byte character followed by a 1-byte character.

**Example 2**

```text
Input:  data = [235,140,4]
Output: false
```

The bytes 11101011 10001100 00000100: the first byte announces a 3-byte character and the second is a valid continuation, but the third byte starts with 0 instead of 10.

## Constraints

- `1 <= data.length <= 2 * 10^4`
- `0 <= data[i] <= 255`

## Signature

```csharp
public bool ValidUtf8(int[] data)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P026_UTF8Validation"
```
