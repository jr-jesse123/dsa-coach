using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P026_UTF8Validation;

public class P026_UTF8ValidationTests
{
    [Theory]
    [MemberData(nameof(P026Data.Cases), MemberType = typeof(P026Data))]
    public void Solve(int[] data, bool expected)
    {
        Assert.Equal(expected, new Solution().ValidUtf8(data));
    }
}
