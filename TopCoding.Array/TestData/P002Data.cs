namespace TopCoding.Array.TestData;

public static class P002Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4 },
        new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1 },
        new object[] { new int[] { 1 }, 0, -1 },
        new object[] { new int[] { 1 }, 1, 0 },
        new object[] { new int[] { 1, 3 }, 3, 1 },
        new object[] { new int[] { 3, 1 }, 1, 1 },
        new object[] { new int[] { 3, 1 }, 3, 0 },
        new object[] { new int[] { 5, 1, 3 }, 5, 0 },
        new object[] { new int[] { 5, 1, 3 }, 0, -1 },
        new object[] { new int[] { 1, 2, 3, 4, 5 }, 5, 4 },
        new object[] { new int[] { 2, 3, 4, 5, 1 }, 1, 4 },
        new object[] { new int[] { -10000, 10000 }, -10000, 0 },
        new object[] { new int[] { 10000, -10000 }, 10000, 0 },
        new object[] { Enumerable.Range(2500, 2500).Concat(Enumerable.Range(0, 2500)).ToArray(), 4999, 2499 },
        new object[] { new int[] { 30, 4, 25 }, -6, -1 },
        new object[] { new int[] { -23, -10, -2 }, -23, 0 },
        new object[] { new int[] { 23, -28 }, -28, 1 },
        new object[] { new int[] { -25, 5, 6, 26 }, 5, 1 },
        new object[] { new int[] { -5, 13, 22, 28, 29, -18, -9 }, 32, -1 },
        new object[] { new int[] { -15, -8, -6, 7, -18, -17 }, 7, 3 },
        new object[] { new int[] { -29, -27, -24, -9, 8, 13, 15, 19, 26, 29 }, -12, -1 },
        new object[] { new int[] { -25, -24, -22, -21, -17, -14, -9, -8, 1, 3, 19, -30 }, -30, 11 },
        new object[] { new int[] { -21, -18, -17, -7, 1, 6, 14, 16, 23, 24, 29, -25 }, 22, -1 },
        new object[] { new int[] { -21, -7, 15 }, 15, 2 },
        new object[] { new int[] { -26, -10, 12 }, -26, 0 },
        new object[] { new int[] { -2, -1, 2, 9, 15, 17, 18, -24, -18, -15, -9 }, 9, 3 },
    };
}
