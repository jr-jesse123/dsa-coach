using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P002_SearchInRotatedSortedArray;

public class P002_SearchInRotatedSortedArrayTests
{
    [Theory]
    [MemberData(nameof(P002Data.Cases), MemberType = typeof(P002Data))]
    public void Solve(int[] nums, int target, int expected)
    {
        Assert.Equal(expected, new Solution().Search(nums, target));
    }
}
