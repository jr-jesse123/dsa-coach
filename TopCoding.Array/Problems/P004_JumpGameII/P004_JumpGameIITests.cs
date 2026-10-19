using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P004_JumpGameII;

public class P004_JumpGameIITests
{
    [Theory]
    [MemberData(nameof(P004Data.Cases), MemberType = typeof(P004Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().Jump(nums));
    }
}
