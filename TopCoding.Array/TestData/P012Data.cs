namespace TopCoding.Array.TestData;

public static class P012Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 100, 4, 200, 1, 3, 2 }, 4 },
        new object[] { new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9 },
        new object[] { new int[0], 0 },
        new object[] { new int[] { 5 }, 1 },
        new object[] { new int[] { 1, 1, 1 }, 1 },
        new object[] { new int[] { 1, 2, 0, 1 }, 3 },
        new object[] { new int[] { -1, 0, 1 }, 3 },
        new object[] { new int[] { -1000000000, 1000000000 }, 1 },
        new object[] { new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }, 7 },
        new object[] { Enumerable.Range(0, 100000).ToArray(), 100000 },
        new object[] { Enumerable.Range(0, 100000).Select(i => i * 2).ToArray(), 1 },
        new object[] { Enumerable.Range(0, 100000).Select(i => 99999 - i).ToArray(), 100000 },
        new object[] { new int[] { -6, 7, 0, -4, 0, -6, 2, 7, -4, 1, 3, 4 }, 5 },
        new object[] { new int[] { 5, 0, -5, -7, 0, 7 }, 1 },
        new object[] { new int[] { -4, 2, -4, -2, 7, 3, 1, 6, -8, 4, 6 }, 4 },
        new object[] { new int[] { 2, 8, 1, 6, 5, 2, -2, 7, -6, 2 }, 4 },
        new object[] { new int[] { 5, 3, 4, -2, -7, -3, 7, 5, 3, -1, -3, -6 }, 3 },
        new object[] { new int[] { 4, 0, -4 }, 1 },
        new object[] { new int[] { 1, -4, 4, -8, 5 }, 2 },
        new object[] { new int[] { -8, 1, -4, -8, 3, 6, -2 }, 1 },
        new object[] { new int[] { 0, 6, -1, 4, 7, 2, -3 }, 2 },
        new object[] { new int[] { 3, -4, -8, -8, 8, 2, 4, 8, 5 }, 4 },
        new object[] { new int[] { 7, 3, -8 }, 1 },
        new object[] { new int[] { 1, -2, -6, -4, 0, -3, 7, -2 }, 3 },
        new object[] { new int[] { -3, 2, 3, 4 }, 3 },
        new object[] { new int[] { -1, -3, -7 }, 1 },
        new object[] { new int[] { 8, 5, 4 }, 2 },
        new object[] { new int[] { 4, 1, 7, 7, 5, -7, 7 }, 2 },
        new object[] { new int[] { 1 }, 1 },
        new object[] { new int[] { 5, 7, -4, 8, -3, -5, 7, -5 }, 3 },
        new object[] { new int[] { -2 }, 1 },
        new object[] { new int[] { 4, 3, 5 }, 3 },
    };
}
