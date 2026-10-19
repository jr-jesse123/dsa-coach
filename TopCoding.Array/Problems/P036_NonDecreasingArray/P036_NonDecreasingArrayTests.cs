using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P036_NonDecreasingArray;

public class P036_NonDecreasingArrayTests
{
    [Theory]
    [MemberData(nameof(P036Data.Cases), MemberType = typeof(P036Data))]
    public void Solve(int[] nums, bool expected)
    {
        Assert.Equal(expected, new Solution().CheckPossibility(nums));
    }
}
