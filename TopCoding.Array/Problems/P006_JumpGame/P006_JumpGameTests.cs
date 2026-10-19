using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P006_JumpGame;

public class P006_JumpGameTests
{
    [Theory]
    [MemberData(nameof(P006Data.Cases), MemberType = typeof(P006Data))]
    public void Solve(int[] nums, bool expected)
    {
        Assert.Equal(expected, new Solution().CanJump(nums));
    }
}
