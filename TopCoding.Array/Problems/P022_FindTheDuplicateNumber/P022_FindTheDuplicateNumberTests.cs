using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P022_FindTheDuplicateNumber;

public class P022_FindTheDuplicateNumberTests
{
    [Theory]
    [MemberData(nameof(P022Data.Cases), MemberType = typeof(P022Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().FindDuplicate(nums));
    }
}
