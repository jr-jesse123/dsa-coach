namespace TopCoding.Array.TestData;

public static class P019Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 3, 2, 1, 5, 6, 4 }, 2, 5 },
        new object[] { new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4 },
        new object[] { new int[] { 1 }, 1, 1 },
        new object[] { new int[] { 2, 1 }, 1, 2 },
        new object[] { new int[] { 2, 1 }, 2, 1 },
        new object[] { new int[] { 5, 5, 5 }, 2, 5 },
        new object[] { new int[] { -1, -2, -3 }, 3, -3 },
        new object[] { new int[] { 7, 6, 5, 4, 3, 2, 1 }, 7, 1 },
        new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1, 7 },
        new object[] { Enumerable.Range(0, 100000).Select(i => (i * 7919) % 20001 - 10000).ToArray(), 50000, 0 },
        new object[] { Enumerable.Range(0, 100000).Select(i => (i * 7919) % 20001 - 10000).ToArray(), 1, 10000 },
        new object[] { Enumerable.Range(0, 100000).Select(i => (i * 7919) % 20001 - 10000).ToArray(), 100000, -10000 },
        new object[] { new int[] { -9, -10, -4, -1, -2, 5 }, 4, -4 },
        new object[] { new int[] { 6, -7, 10, 9, 1, -9, 2, 6, -4, 9, -2 }, 6, 2 },
        new object[] { new int[] { 8, 0, 8, -5, 6, 10, -7, -4 }, 6, -4 },
        new object[] { new int[] { -7, -2, 10, 3, -4, 7, -1, 9 }, 8, -7 },
        new object[] { new int[] { -4, -7, -2, 5, 6, 10, 10, 5, 5, -3, 0, 4 }, 4, 5 },
        new object[] { new int[] { -7, 1, -1, -6, -4, 5, 8 }, 1, 8 },
        new object[] { new int[] { -2, -10, -6, -7, -4, 9, 4, 4, 10 }, 4, 4 },
        new object[] { new int[] { -9, 1, -6, 9, 1, 9, -2, -9, -10, -4, -8 }, 3, 1 },
        new object[] { new int[] { -5, 7 }, 1, 7 },
        new object[] { new int[] { -8, 8 }, 2, -8 },
        new object[] { new int[] { 8, 4, 10, -2, 5, -7, 6 }, 6, -2 },
        new object[] { new int[] { -5, 5 }, 2, -5 },
        new object[] { new int[] { -1, 6, 8, 3, -8, -5, 1, -5, -3, -3, 1, 5 }, 8, -3 },
        new object[] { new int[] { 7, 7, -10, 3, -5, 7, 7 }, 7, -10 },
        new object[] { new int[] { -9, -1, 0, -4, -6, 10, -1, 8, -3 }, 7, -4 },
        new object[] { new int[] { -6 }, 1, -6 },
        new object[] { new int[] { 1, 0, 0, -4, -1, 10, 7, 2, 4 }, 7, 0 },
        new object[] { new int[] { -3, 9, 6, -7, 5, 3, -4, 9, -2, 5, -9, 8 }, 6, 5 },
        new object[] { new int[] { -8, -10 }, 1, -8 },
        new object[] { new int[] { 6, 1, -6, -7, -1, 3, 10, 1, 6, -9, -3, 4 }, 10, -6 },
    };
}
