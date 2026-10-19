using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P030_132Pattern;

public class P030_132PatternTests
{
    [Theory]
    [MemberData(nameof(P030Data.Cases), MemberType = typeof(P030Data))]
    public void Solve(int[] nums, bool expected)
    {
        Assert.Equal(expected, new Solution().Find132pattern(nums));
    }
}
