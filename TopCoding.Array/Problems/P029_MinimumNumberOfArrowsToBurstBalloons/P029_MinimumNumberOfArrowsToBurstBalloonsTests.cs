using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P029_MinimumNumberOfArrowsToBurstBalloons;

public class P029_MinimumNumberOfArrowsToBurstBalloonsTests
{
    [Theory]
    [MemberData(nameof(P029Data.Cases), MemberType = typeof(P029Data))]
    public void Solve(int[][] points, int expected)
    {
        Assert.Equal(expected, new Solution().FindMinArrowShots(points));
    }
}
