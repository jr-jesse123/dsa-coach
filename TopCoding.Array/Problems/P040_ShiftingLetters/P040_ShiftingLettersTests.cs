using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P040_ShiftingLetters;

public class P040_ShiftingLettersTests
{
    [Theory]
    [MemberData(nameof(P040Data.Cases), MemberType = typeof(P040Data))]
    public void Solve(string s, int[] shifts, string expected)
    {
        Assert.Equal(expected, new Solution().ShiftingLetters(s, shifts));
    }
}
