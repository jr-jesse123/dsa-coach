using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P031_TargetSum;

public class P031_TargetSumTests
{
    [Theory]
    [MemberData(nameof(P031Data.Cases), MemberType = typeof(P031Data))]
    public void Solve(int[] nums, int target, int expected)
    {
        Assert.Equal(expected, new Solution().FindTargetSumWays(nums, target));
    }
}
