# 38. Delete and Earn

- LeetCode #740 · Medium
- Implement `Solution.DeleteAndEarn` in `Solution.cs`, then run `P038_DeleteAndEarnTests`.

## Problem

You may repeat this operation any number of times: pick any `nums[i]`, delete it and earn `nums[i]` points. Afterwards you
must also delete every element equal to `nums[i] - 1` and every element equal to `nums[i] + 1`.

Return the maximum number of points you can earn.

## Examples

**Example 1**

```text
Input:  nums = [3,4,2]
Output: 6
```

Delete 4 (earn 4; 3 is deleted too), then delete 2 (earn 2): 6 points.

**Example 2**

```text
Input:  nums = [2,2,3,3,3,4]
Output: 9
```

Delete a 3 (earn 3; all 2s and 4s go too), then the remaining two 3s: 9 points.

## Constraints

- `1 <= nums.length <= 2 * 10^4`
- `1 <= nums[i] <= 10^4`

## Signature

```csharp
public int DeleteAndEarn(int[] nums)
```

## Run

```text
dotnet test --filter "FullyQualifiedName~P038_DeleteAndEarn"
```
