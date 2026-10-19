using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P003_ValidSudoku;

public class P003_ValidSudokuTests
{
    [Theory]
    [MemberData(nameof(P003Data.Cases), MemberType = typeof(P003Data))]
    public void Solve(char[][] board, bool expected)
    {
        Assert.Equal(expected, new Solution().IsValidSudoku(board));
    }
}
