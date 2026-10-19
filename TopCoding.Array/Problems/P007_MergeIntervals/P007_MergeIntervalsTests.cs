using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P007_MergeIntervals;

public class P007_MergeIntervalsTests
{
    [Theory]
    [MemberData(nameof(P007Data.Cases), MemberType = typeof(P007Data))]
    public void Solve(int[][] intervals, int[][] expected)
    {
        Assert.Equal(expected.OrderBy(r => r[0]).ThenBy(r => r[1]), new Solution().Merge(intervals).OrderBy(r => r[0]).ThenBy(r => r[1]));
    }
}
