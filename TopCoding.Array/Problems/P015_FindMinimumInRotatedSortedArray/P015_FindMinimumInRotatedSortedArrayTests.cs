using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P015_FindMinimumInRotatedSortedArray;

public class P015_FindMinimumInRotatedSortedArrayTests
{
    [Theory]
    [MemberData(nameof(P015Data.Cases), MemberType = typeof(P015Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().FindMin(nums));
    }
}
