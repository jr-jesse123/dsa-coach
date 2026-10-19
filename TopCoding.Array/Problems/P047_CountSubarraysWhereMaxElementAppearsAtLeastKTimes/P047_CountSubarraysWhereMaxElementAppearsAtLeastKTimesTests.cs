using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P047_CountSubarraysWhereMaxElementAppearsAtLeastKTimes;

public class P047_CountSubarraysWhereMaxElementAppearsAtLeastKTimesTests
{
    [Theory]
    [MemberData(nameof(P047Data.Cases), MemberType = typeof(P047Data))]
    public void Solve(int[] nums, int k, long expected)
    {
        Assert.Equal(expected, new Solution().CountSubarrays(nums, k));
    }
}
