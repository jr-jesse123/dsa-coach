using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P027_NonOverlappingIntervals;

public class P027_NonOverlappingIntervalsTests
{
    [Theory]
    [MemberData(nameof(P027Data.Cases), MemberType = typeof(P027Data))]
    public void Solve(int[][] intervals, int expected)
    {
        Assert.Equal(expected, new Solution().EraseOverlapIntervals(intervals));
    }
}
