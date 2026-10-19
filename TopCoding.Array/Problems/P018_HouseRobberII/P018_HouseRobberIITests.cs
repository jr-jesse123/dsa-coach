using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P018_HouseRobberII;

public class P018_HouseRobberIITests
{
    [Theory]
    [MemberData(nameof(P018Data.Cases), MemberType = typeof(P018Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().Rob(nums));
    }
}
