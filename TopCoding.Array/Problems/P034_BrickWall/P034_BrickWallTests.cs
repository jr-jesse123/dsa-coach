using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P034_BrickWall;

public class P034_BrickWallTests
{
    [Theory]
    [MemberData(nameof(P034Data.Cases), MemberType = typeof(P034Data))]
    public void Solve(int[][] wall, int expected)
    {
        Assert.Equal(expected, new Solution().LeastBricks(wall));
    }
}
