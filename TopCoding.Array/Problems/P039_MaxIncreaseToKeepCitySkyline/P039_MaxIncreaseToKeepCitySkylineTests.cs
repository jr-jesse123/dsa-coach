using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P039_MaxIncreaseToKeepCitySkyline;

public class P039_MaxIncreaseToKeepCitySkylineTests
{
    [Theory]
    [MemberData(nameof(P039Data.Cases), MemberType = typeof(P039Data))]
    public void Solve(int[][] grid, int expected)
    {
        Assert.Equal(expected, new Solution().MaxIncreaseKeepingSkyline(grid));
    }
}
