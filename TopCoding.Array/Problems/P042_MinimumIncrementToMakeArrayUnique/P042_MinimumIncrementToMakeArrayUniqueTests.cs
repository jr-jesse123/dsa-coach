using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P042_MinimumIncrementToMakeArrayUnique;

public class P042_MinimumIncrementToMakeArrayUniqueTests
{
    [Theory]
    [MemberData(nameof(P042Data.Cases), MemberType = typeof(P042Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().MinIncrementForUnique(nums));
    }
}
