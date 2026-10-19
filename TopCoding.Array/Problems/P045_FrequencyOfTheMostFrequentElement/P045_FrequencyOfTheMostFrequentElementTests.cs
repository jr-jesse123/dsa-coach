using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P045_FrequencyOfTheMostFrequentElement;

public class P045_FrequencyOfTheMostFrequentElementTests
{
    [Theory]
    [MemberData(nameof(P045Data.Cases), MemberType = typeof(P045Data))]
    public void Solve(int[] nums, int k, int expected)
    {
        Assert.Equal(expected, new Solution().MaxFrequency(nums, k));
    }
}
