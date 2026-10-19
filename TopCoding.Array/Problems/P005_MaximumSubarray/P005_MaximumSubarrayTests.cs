using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P005_MaximumSubarray;

public class P005_MaximumSubarrayTests
{
    [Theory]
    [MemberData(nameof(P005Data.Cases), MemberType = typeof(P005Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().MaxSubArray(nums));
    }
}
