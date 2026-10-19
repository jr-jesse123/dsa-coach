using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P019_KthLargestElementInAnArray;

public class P019_KthLargestElementInAnArrayTests
{
    [Theory]
    [MemberData(nameof(P019Data.Cases), MemberType = typeof(P019Data))]
    public void Solve(int[] nums, int k, int expected)
    {
        Assert.Equal(expected, new Solution().FindKthLargest(nums, k));
    }
}
