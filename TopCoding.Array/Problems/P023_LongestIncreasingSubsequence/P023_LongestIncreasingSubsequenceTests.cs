using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P023_LongestIncreasingSubsequence;

public class P023_LongestIncreasingSubsequenceTests
{
    [Theory]
    [MemberData(nameof(P023Data.Cases), MemberType = typeof(P023Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().LengthOfLIS(nums));
    }
}
