# 45. Frequency of the Most Frequent Element

- LeetCode #1838 · Medium
- Implement `Solution.MaxFrequency` in `Solution.cs`, then run `P045_FrequencyOfTheMostFrequentElementTests`.

## Problem

The frequency of an element is how many times it occurs in the array. In one operation you may pick any index and
increment its element by 1. Return the maximum possible frequency of any element after at most `k` operations.

## Examples

**Example 1**

```text
Input:  nums = [1,2,4], k = 5
Output: 3
```

Increment 1 three times and 2 twice: 4 then has frequency 3.

**Example 2**

```text
Input:  nums = [1,4,8,13], k = 5
Output: 2
```

For example, increment 1 three times to get [4,4,8,13]; 4 has frequency 2.

**Example 3**

```text
Input:  nums = [3,9,6], k = 2
Output: 1
```

## Constraints

- `1 <= nums.length <= 10^5`
- `1 <= nums[i] <= 10^5`
- `1 <= k <= 10^5`

## Signature

```csharp
public int MaxFrequency(int[] nums, int k)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P045_FrequencyOfTheMostFrequentElement"
```
