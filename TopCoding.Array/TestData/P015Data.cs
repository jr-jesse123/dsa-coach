namespace TopCoding.Array.TestData;

public static class P015Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 3, 4, 5, 1, 2 }, 1 },
        new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0 },
        new object[] { new int[] { 11, 13, 15, 17 }, 11 },
        new object[] { new int[] { 1 }, 1 },
        new object[] { new int[] { 2, 1 }, 1 },
        new object[] { new int[] { 1, 2 }, 1 },
        new object[] { new int[] { 3, 1, 2 }, 1 },
        new object[] { new int[] { 2, 3, 1 }, 1 },
        new object[] { new int[] { -5000, 5000 }, -5000 },
        new object[] { new int[] { 5000, -5000 }, -5000 },
        new object[] { Enumerable.Range(-2500, 5000).ToArray(), -2500 },
        new object[] { Enumerable.Range(0, 2500).Concat(Enumerable.Range(-5000, 2500)).ToArray(), -5000 },
        new object[] { new int[] { -36, -28, -24, -9 }, -36 },
        new object[] { new int[] { -29, -17, -12, -10, -6, -2, -1, 2, 9, 40, -40, -39 }, -40 },
        new object[] { new int[] { 17, 21, 28, 29, 31, 39, -24, -23, -20 }, -24 },
        new object[] { new int[] { -30 }, -30 },
        new object[] { new int[] { -34, -30, 0, 6, 10, 29, 30 }, -34 },
        new object[] { new int[] { 1, 20 }, 1 },
        new object[] { new int[] { -19, -4, 15, -37 }, -37 },
        new object[] { new int[] { 8, 12, 37, -29, -28, -21, -9, -7, -6, -5, -2 }, -29 },
        new object[] { new int[] { 6, 17, 18, 22, 23, 39, -22, -16, -5, -3 }, -22 },
        new object[] { new int[] { -40, -28, -15, 3, 7 }, -40 },
        new object[] { new int[] { 30, -30, -25, -16, -13, -9, -7, 11, 29 }, -30 },
        new object[] { new int[] { -28, 18 }, -28 },
        new object[] { new int[] { -15, 7, 24, 27, 29, -34 }, -34 },
        new object[] { new int[] { -25, -14, -8, 2, 5, 11, 20, 21, 28, -36, -29 }, -36 },
        new object[] { new int[] { 6 }, 6 },
        new object[] { new int[] { -28, -16, 10, 11, 32, 37, -31 }, -31 },
        new object[] { new int[] { -29, -14, 32, -35 }, -35 },
        new object[] { new int[] { -33, -29, -13, -5 }, -33 },
        new object[] { new int[] { 38, 39, -29, -27, -26, -25, -14, 9, 30 }, -29 },
        new object[] { new int[] { 14, 15, 19, 24, 26, 35, 38, -24, -22, -13, -3, 8 }, -24 },
    };
}
