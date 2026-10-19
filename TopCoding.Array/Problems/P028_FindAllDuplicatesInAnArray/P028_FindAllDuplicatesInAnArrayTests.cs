using TopCoding.Array.TestData;
using Xunit;

namespace TopCoding.Array.Problems.P028_FindAllDuplicatesInAnArray;

public class P028_FindAllDuplicatesInAnArrayTests
{
    [Theory]
    [MemberData(nameof(P028Data.Cases), MemberType = typeof(P028Data))]
    public void Solve(int[] nums, int[] expected)
    {
        Assert.Equal(expected.OrderBy(x => x), new Solution().FindDuplicates(nums).OrderBy(x => x));
    }
}
