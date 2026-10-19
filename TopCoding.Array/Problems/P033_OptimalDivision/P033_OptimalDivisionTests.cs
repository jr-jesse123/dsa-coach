using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P033_OptimalDivision;

public class P033_OptimalDivisionTests
{
    [Theory]
    [MemberData(nameof(P033Data.Cases), MemberType = typeof(P033Data))]
    public void Solve(int[] nums, string expected)
    {
        Assert.Equal(expected, new Solution().OptimalDivision(nums));
    }
}
