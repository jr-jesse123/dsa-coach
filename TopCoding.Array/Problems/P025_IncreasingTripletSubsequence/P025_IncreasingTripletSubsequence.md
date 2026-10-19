# 25. Increasing Triplet Subsequence

- LeetCode #334 · Medium
- Implement `Solution.IncreasingTriplet` in `Solution.cs`, then run `P025_IncreasingTripletSubsequenceTests`.

## Problem

Return `true` if there exist indices `i < j < k` with `nums[i] < nums[j] < nums[k]`, otherwise `false`.

## Examples

**Example 1**

```text
Input:  nums = [1,2,3,4,5]
Output: true
```

Any triplet where i < j < k is valid.

**Example 2**

```text
Input:  nums = [5,4,3,2,1]
Output: false
```

No triplet exists.

**Example 3**

```text
Input:  nums = [2,1,5,0,4,6]
Output: true
```

The triplet (3, 4, 5) is valid: nums[3] = 0 < nums[4] = 4 < nums[5] = 6.

## Constraints

- `1 <= nums.length <= 5 * 10^5`
- `-2^31 <= nums[i] <= 2^31 - 1`

## Follow-up

Can you do it in O(n) time and O(1) space?

## Signature

```csharp
public bool IncreasingTriplet(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P025_IncreasingTripletSubsequence"
```
