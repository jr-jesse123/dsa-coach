using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P046_EliminateMaximumNumberOfMonsters;

public class P046_EliminateMaximumNumberOfMonstersTests
{
    [Theory]
    [MemberData(nameof(P046Data.Cases), MemberType = typeof(P046Data))]
    public void Solve(int[] dist, int[] speed, int expected)
    {
        Assert.Equal(expected, new Solution().EliminateMaximum(dist, speed));
    }
}
