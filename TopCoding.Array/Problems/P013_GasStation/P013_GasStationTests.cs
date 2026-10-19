using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P013_GasStation;

public class P013_GasStationTests
{
    [Theory]
    [MemberData(nameof(P013Data.Cases), MemberType = typeof(P013Data))]
    public void Solve(int[] gas, int[] cost, int expected)
    {
        Assert.Equal(expected, new Solution().CanCompleteCircuit(gas, cost));
    }
}
