using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P038_DeleteAndEarn;

public class P038_DeleteAndEarnTests
{
    [Theory]
    [MemberData(nameof(P038Data.Cases), MemberType = typeof(P038Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().DeleteAndEarn(nums));
    }
}
