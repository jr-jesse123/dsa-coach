using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P001_ContainerWithMostWater;

public class P001_ContainerWithMostWaterTests
{
    [Theory]
    [MemberData(nameof(P001Data.Cases), MemberType = typeof(P001Data))]
    public void Solve(int[] height, int expected)
    {
        Assert.Equal(expected, new Solution().MaxArea(height));
    }
}
