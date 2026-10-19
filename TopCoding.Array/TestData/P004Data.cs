namespace TopCoding.Array.TestData;

public static class P004Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 2, 3, 1, 1, 4 }, 2 },
        new object[] { new int[] { 2, 3, 0, 1, 4 }, 2 },
        new object[] { new int[] { 0 }, 0 },
        new object[] { new int[] { 1 }, 0 },
        new object[] { new int[] { 1, 1, 1, 1 }, 3 },
        new object[] { new int[] { 5, 1, 1, 1, 1, 1 }, 1 },
        new object[] { new int[] { 1, 2, 1, 1, 1 }, 3 },
        new object[] { new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, 1 },
        new object[] { Enumerable.Repeat(1, 10000).ToArray(), 9999 },
        new object[] { Enumerable.Repeat(1000, 10000).ToArray(), 10 },
        new object[] { new int[] { 3, 2, 5, 5, 4, 1, 2 }, 2 },
        new object[] { new int[] { 2, 2, 0, 5, 5 }, 3 },
        new object[] { new int[] { 4, 0, 4, 2 }, 1 },
        new object[] { new int[] { 2, 2 }, 1 },
        new object[] { new int[] { 4, 5, 1, 0, 3, 5, 1, 1, 4, 0, 5, 5 }, 4 },
        new object[] { new int[] { 2, 1, 2, 4, 5 }, 2 },
        new object[] { new int[] { 4, 4, 5, 4, 4, 2, 1, 2, 4, 1 }, 3 },
        new object[] { new int[] { 3, 1, 0, 1, 3, 4, 0, 1, 1, 2, 3, 2 }, 5 },
        new object[] { new int[] { 3, 5, 3 }, 1 },
        new object[] { new int[] { 1, 3, 0, 0, 5, 4, 0, 1, 0, 1 }, 3 },
        new object[] { new int[] { 3, 4, 1, 4, 3, 3, 3, 2, 3, 3 }, 3 },
        new object[] { new int[] { 3 }, 0 },
    };
}
