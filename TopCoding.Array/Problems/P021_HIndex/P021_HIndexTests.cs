using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P021_HIndex;

public class P021_HIndexTests
{
    [Theory]
    [MemberData(nameof(P021Data.Cases), MemberType = typeof(P021Data))]
    public void Solve(int[] citations, int expected)
    {
        Assert.Equal(expected, new Solution().HIndex(citations));
    }
}
