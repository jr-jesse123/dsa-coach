using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P008_UniquePathsII;

public class P008_UniquePathsIITests
{
    [Theory]
    [MemberData(nameof(P008Data.Cases), MemberType = typeof(P008Data))]
    public void Solve(int[][] obstacleGrid, int expected)
    {
        Assert.Equal(expected, new Solution().UniquePathsWithObstacles(obstacleGrid));
    }
}
