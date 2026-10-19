using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P032_ContiguousArray;

public class P032_ContiguousArrayTests
{
    [Theory]
    [MemberData(nameof(P032Data.Cases), MemberType = typeof(P032Data))]
    public void Solve(int[] nums, int expected)
    {
        Assert.Equal(expected, new Solution().FindMaxLength(nums));
    }
}
