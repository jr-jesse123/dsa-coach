using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P011_Triangle;

public class P011_TriangleTests
{
    [Theory]
    [MemberData(nameof(P011Data.Cases), MemberType = typeof(P011Data))]
    public void Solve(int[][] triangle, int expected)
    {
        Assert.Equal(expected, new Solution().MinimumTotal(triangle));
    }
}
