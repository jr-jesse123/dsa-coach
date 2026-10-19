using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P041_MaximizeDistanceToClosestPerson;

public class P041_MaximizeDistanceToClosestPersonTests
{
    [Theory]
    [MemberData(nameof(P041Data.Cases), MemberType = typeof(P041Data))]
    public void Solve(int[] seats, int expected)
    {
        Assert.Equal(expected, new Solution().MaxDistToClosest(seats));
    }
}
