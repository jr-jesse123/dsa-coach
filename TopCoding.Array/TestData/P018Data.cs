namespace TopCoding.Array.TestData;

public static class P018Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 2, 3, 2 }, 3 },
        new object[] { new int[] { 1, 2, 3, 1 }, 4 },
        new object[] { new int[] { 1, 2, 3 }, 3 },
        new object[] { new int[] { 0 }, 0 },
        new object[] { new int[] { 7 }, 7 },
        new object[] { new int[] { 1, 2 }, 2 },
        new object[] { new int[] { 2, 1 }, 2 },
        new object[] { new int[] { 1, 1, 1 }, 1 },
        new object[] { new int[] { 5, 1, 1, 5 }, 6 },
        new object[] { new int[] { 200, 3, 140, 20, 10 }, 340 },
        new object[] { new int[] { 1, 3, 1, 3, 100 }, 103 },
        new object[] { Enumerable.Repeat(1000, 100).ToArray(), 50000 },
        new object[] { new int[] { 18, 19, 13, 3, 17, 1, 11, 13, 12 }, 61 },
        new object[] { new int[] { 15, 12, 9, 30, 26, 16, 18, 25 }, 83 },
        new object[] { new int[] { 30, 20, 12 }, 30 },
        new object[] { new int[] { 7, 11, 15, 27, 12, 19, 17 }, 57 },
        new object[] { new int[] { 22, 21, 2, 27 }, 48 },
        new object[] { new int[] { 0, 5, 23, 30, 4, 28, 29, 21 }, 84 },
        new object[] { new int[] { 15, 22, 18 }, 22 },
        new object[] { new int[] { 5, 7, 19, 18, 19, 16, 14 }, 52 },
        new object[] { new int[] { 23, 28, 6, 3, 3, 7 }, 38 },
        new object[] { new int[] { 30, 8, 23, 20, 2, 28 }, 56 },
        new object[] { new int[] { 27, 27, 17, 15, 5, 2, 23, 7 }, 72 },
        new object[] { new int[] { 10, 4, 17, 11, 0, 11, 0 }, 38 },
        new object[] { new int[] { 8, 1, 3, 24, 17, 8 }, 33 },
        new object[] { new int[] { 10, 30, 7, 15, 12 }, 45 },
        new object[] { new int[] { 15 }, 15 },
        new object[] { new int[] { 20, 13, 1, 24, 5, 23, 10, 17, 5, 24, 5, 3 }, 108 },
        new object[] { new int[] { 29, 30, 16, 8, 18 }, 48 },
        new object[] { new int[] { 9, 6, 2, 1, 9 }, 15 },
        new object[] { new int[] { 27, 28, 4, 12 }, 40 },
        new object[] { new int[] { 4, 1, 14, 17, 2, 13, 10 }, 34 },
    };
}
