using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P010_SearchA2DMatrix;

public class P010_SearchA2DMatrixTests
{
    [Theory]
    [MemberData(nameof(P010Data.Cases), MemberType = typeof(P010Data))]
    public void Solve(int[][] matrix, int target, bool expected)
    {
        Assert.Equal(expected, new Solution().SearchMatrix(matrix, target));
    }
}
