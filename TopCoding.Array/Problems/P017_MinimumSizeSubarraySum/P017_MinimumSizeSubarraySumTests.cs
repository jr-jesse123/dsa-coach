using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P017_MinimumSizeSubarraySum;

public class P017_MinimumSizeSubarraySumTests
{
    [Theory]
    [MemberData(nameof(P017Data.Cases), MemberType = typeof(P017Data))]
    public void Solve(int target, int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().MinSubArrayLen(target, nums));
    }
}
