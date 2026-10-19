namespace TopCoding.Array.TestData;

public static class P005Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6 },
        new object[] { new int[] { 1 }, 1 },
        new object[] { new int[] { 5, 4, -1, 7, 8 }, 23 },
        new object[] { new int[] { -1 }, -1 },
        new object[] { new int[] { -3, -2, -1 }, -1 },
        new object[] { new int[] { 0 }, 0 },
        new object[] { new int[] { 0, 0, 0 }, 0 },
        new object[] { new int[] { -1, 0, -2 }, 0 },
        new object[] { new int[] { 1, 2, 3, 4 }, 10 },
        new object[] { new int[] { -10000, 10000 }, 10000 },
        new object[] { new int[] { 10000, -10000, 10000 }, 10000 },
        new object[] { Enumerable.Range(0, 100000).Select(i => i % 2 == 0 ? 10000 : -9999).ToArray(), 59999 },
        new object[] { Enumerable.Repeat(-10000, 100000).ToArray(), -10000 },
        new object[] { new int[] { -1, -6, 0, 2, 10, 7, 8, -8, 8, 8 }, 35 },
        new object[] { new int[] { 1, -3, 2, 4, -7, -9, 8, -6, -4, 7 }, 8 },
        new object[] { new int[] { 9, -8, 10, -2, 10 }, 19 },
        new object[] { new int[] { -3 }, -3 },
        new object[] { new int[] { -8, 8, 1, 4 }, 13 },
        new object[] { new int[] { 2, 0, 10, -5, -6, 5, -1, -8 }, 12 },
        new object[] { new int[] { -6, -8, -4, 6, -4, -9, -2, -7, 2 }, 6 },
        new object[] { new int[] { -4, 9, -9, -9, 5, 3, -8 }, 9 },
        new object[] { new int[] { 7, 8, -5, 1, 2 }, 15 },
        new object[] { new int[] { 9, 4, -9, -2, 0, 10, -6, -3, 4, -3, 10, 6 }, 20 },
        new object[] { new int[] { -9 }, -9 },
        new object[] { new int[] { -7, 8 }, 8 },
    };
}
