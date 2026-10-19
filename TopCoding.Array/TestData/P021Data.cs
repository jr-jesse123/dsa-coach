namespace TopCoding.Array.TestData;

public static class P021Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 3, 0, 6, 1, 5 }, 3 },
        new object[] { new int[] { 1, 3, 1 }, 1 },
        new object[] { new int[] { 0 }, 0 },
        new object[] { new int[] { 1 }, 1 },
        new object[] { new int[] { 100 }, 1 },
        new object[] { new int[] { 0, 0, 0 }, 0 },
        new object[] { new int[] { 1, 1, 1, 1 }, 1 },
        new object[] { new int[] { 4, 4, 4, 4 }, 4 },
        new object[] { new int[] { 5, 5, 5, 5, 5 }, 5 },
        new object[] { new int[] { 0, 1, 2, 3, 4, 5 }, 3 },
        new object[] { new int[] { 11, 15 }, 2 },
        new object[] { new int[] { 1000, 1000, 1000, 1000, 1000 }, 5 },
        new object[] { Enumerable.Repeat(1000, 5000).ToArray(), 1000 },
        new object[] { Enumerable.Range(0, 5000).Select(i => i % 1001).ToArray(), 833 },
        new object[] { new int[] { 8, 1, 7, 4, 0, 5, 2, 9 }, 4 },
        new object[] { new int[] { 3, 9, 11, 2, 11, 9 }, 4 },
        new object[] { new int[] { 8, 6, 5, 5, 12 }, 5 },
        new object[] { new int[] { 8, 5 }, 2 },
        new object[] { new int[] { 9, 8 }, 2 },
        new object[] { new int[] { 1, 8, 6, 5, 2, 5, 1, 6, 10 }, 5 },
        new object[] { new int[] { 4, 6, 5, 11, 12, 12, 2 }, 5 },
        new object[] { new int[] { 3, 1, 6, 3 }, 3 },
        new object[] { new int[] { 1, 11, 8, 0, 12, 12, 8, 10, 6, 8, 3, 3 }, 7 },
        new object[] { new int[] { 11, 6, 0, 1, 4, 4, 2, 7 }, 4 },
        new object[] { new int[] { 10, 8, 10, 2, 1, 0, 2, 12, 11 }, 5 },
        new object[] { new int[] { 12, 9, 11, 2, 9 }, 4 },
        new object[] { new int[] { 6, 4, 6, 7, 7, 3, 8, 11 }, 6 },
        new object[] { new int[] { 3, 3, 11, 4, 4, 12, 6, 5, 3, 10 }, 5 },
        new object[] { new int[] { 9, 6, 10, 4, 11, 4, 6, 12, 0 }, 6 },
        new object[] { new int[] { 1, 6, 3, 1, 4, 6, 9, 3, 2, 6 }, 4 },
        new object[] { new int[] { 6, 7, 2, 1 }, 2 },
        new object[] { new int[] { 10, 9, 12, 6, 10, 2 }, 5 },
        new object[] { new int[] { 12, 10, 11, 4, 4, 5, 10, 3, 7, 12, 2, 4 }, 6 },
        new object[] { new int[] { 5, 0, 3, 9, 4, 6, 5, 1 }, 4 },
    };
}
