using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P012_LongestConsecutiveSequence;

public class P012_LongestConsecutiveSequenceTests
{
    [Theory]
    [MemberData(nameof(P012Data.Cases), MemberType = typeof(P012Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().LongestConsecutive(nums));
    }
}
