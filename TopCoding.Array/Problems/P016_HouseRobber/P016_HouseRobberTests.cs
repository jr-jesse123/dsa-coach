using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P016_HouseRobber;

public class P016_HouseRobberTests
{
    [Theory]
    [MemberData(nameof(P016Data.Cases), MemberType = typeof(P016Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().Rob(nums));
    }
}
