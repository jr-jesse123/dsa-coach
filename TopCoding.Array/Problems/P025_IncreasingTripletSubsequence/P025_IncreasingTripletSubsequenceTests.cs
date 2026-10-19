using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P025_IncreasingTripletSubsequence;

public class P025_IncreasingTripletSubsequenceTests
{
    [Theory]
    [MemberData(nameof(P025Data.Cases), MemberType = typeof(P025Data))]
    public void Solve(int[] nums, bool expected)
    {
        Assert.Equal(expected, new Solution().IncreasingTriplet(nums));
    }
}
