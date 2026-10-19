using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P020_MaximalSquare;

public class P020_MaximalSquareTests
{
    [Theory]
    [MemberData(nameof(P020Data.Cases), MemberType = typeof(P020Data))]
    public void Solve(char[][] matrix, int expected)
    {
        Assert.Equal(expected, new Solution().MaximalSquare(matrix));
    }
}
