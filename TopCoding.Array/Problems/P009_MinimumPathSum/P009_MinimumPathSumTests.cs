using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P009_MinimumPathSum;

public class P009_MinimumPathSumTests
{
    [Theory]
    [MemberData(nameof(P009Data.Cases), MemberType = typeof(P009Data))]
    public void Solve(int[][] grid, int expected)
    {
        Assert.Equal(expected, new Solution().MinPathSum(grid));
    }
}
