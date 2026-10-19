using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P035_SubarraySumEqualsK;

public class P035_SubarraySumEqualsKTests
{
    [Theory]
    [MemberData(nameof(P035Data.Cases), MemberType = typeof(P035Data))]
    public void Solve(int[] nums, int k, int expected)
    {
        Assert.Equal(expected, new Solution().SubarraySum(nums, k));
    }
}
