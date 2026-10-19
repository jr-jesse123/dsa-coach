using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P037_SubarrayProductLessThanK;

public class P037_SubarrayProductLessThanKTests
{
    [Theory]
    [MemberData(nameof(P037Data.Cases), MemberType = typeof(P037Data))]
    public void Solve(int[] nums, int k, int expected)
    {
        Assert.Equal(expected, new Solution().NumSubarrayProductLessThanK(nums, k));
    }
}
