using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P044_FindTheWinnerOfAnArrayGame;

public class P044_FindTheWinnerOfAnArrayGameTests
{
    [Theory]
    [MemberData(nameof(P044Data.Cases), MemberType = typeof(P044Data))]
    public void Solve(int[] arr, int k, int expected)
    {
        Assert.Equal(expected, new Solution().GetWinner(arr, k));
    }
}
