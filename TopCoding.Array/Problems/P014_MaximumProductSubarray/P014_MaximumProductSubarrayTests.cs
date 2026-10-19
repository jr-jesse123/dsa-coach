using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P014_MaximumProductSubarray;

public class P014_MaximumProductSubarrayTests
{
    [Theory]
    [MemberData(nameof(P014Data.Cases), MemberType = typeof(P014Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().MaxProduct(nums));
    }
}
