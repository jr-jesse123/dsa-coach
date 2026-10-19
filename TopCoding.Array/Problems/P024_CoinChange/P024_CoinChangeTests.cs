using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P024_CoinChange;

public class P024_CoinChangeTests
{
    [Theory]
    [MemberData(nameof(P024Data.Cases), MemberType = typeof(P024Data))]
    public void Solve(int[] coins, int amount, int expected)
    {
        Assert.Equal(expected, new Solution().CoinChange(coins, amount));
    }
}
