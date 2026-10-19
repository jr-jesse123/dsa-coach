using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P043_MaxConsecutiveOnesIII;

public class P043_MaxConsecutiveOnesIIITests
{
    [Theory]
    [MemberData(nameof(P043Data.Cases), MemberType = typeof(P043Data))]
    public void Solve(int[] nums, int k, int expected)
    {
        Assert.Equal(expected, new Solution().LongestOnes(nums, k));
    }
}
