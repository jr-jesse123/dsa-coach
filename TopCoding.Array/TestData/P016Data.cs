namespace TopCoding.Array.TestData;

public static class P016Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 1, 2, 3, 1 }, 4 },
        new object[] { new int[] { 2, 7, 9, 3, 1 }, 12 },
        new object[] { new int[] { 0 }, 0 },
        new object[] { new int[] { 5 }, 5 },
        new object[] { new int[] { 1, 2 }, 2 },
        new object[] { new int[] { 2, 1 }, 2 },
        new object[] { new int[] { 2, 1, 1, 2 }, 4 },
        new object[] { new int[] { 0, 0, 0 }, 0 },
        new object[] { new int[] { 400, 1, 1, 400 }, 800 },
        new object[] { new int[] { 1, 3, 1, 3, 100 }, 103 },
        new object[] { Enumerable.Repeat(400, 100).ToArray(), 20000 },
        new object[] { Enumerable.Range(0, 100).Select(i => i % 2 == 0 ? 400 : 0).ToArray(), 20000 },
        new object[] { new int[] { 11, 20, 7, 23, 21, 16, 3, 30 }, 89 },
        new object[] { new int[] { 4, 22, 24, 6, 7, 22, 22, 24, 28, 29 }, 103 },
        new object[] { new int[] { 0, 4, 9, 20, 30, 17 }, 41 },
        new object[] { new int[] { 23, 28, 1, 11, 11, 25 }, 64 },
        new object[] { new int[] { 30, 4, 11, 20, 10 }, 51 },
        new object[] { new int[] { 19, 17, 28, 12, 4, 28, 23, 4, 14 }, 89 },
        new object[] { new int[] { 15, 30, 2, 19, 15, 11, 5 }, 60 },
        new object[] { new int[] { 5, 12, 28, 12, 28 }, 61 },
        new object[] { new int[] { 8, 0, 20, 13, 24, 2, 16, 18 }, 70 },
        new object[] { new int[] { 10, 3, 27, 23, 30, 26, 26, 0, 6, 11, 23 }, 122 },
        new object[] { new int[] { 23, 9, 17 }, 40 },
        new object[] { new int[] { 14, 8, 23 }, 37 },
        new object[] { new int[] { 15, 1, 7, 11 }, 26 },
        new object[] { new int[] { 3, 11, 27, 12 }, 30 },
        new object[] { new int[] { 15, 9, 0, 24, 13 }, 39 },
        new object[] { new int[] { 9, 18, 15, 15, 12, 7, 5, 5, 28 }, 69 },
        new object[] { new int[] { 21, 24, 19, 7, 15, 20, 0, 6, 23, 7, 2, 22 }, 105 },
        new object[] { new int[] { 6, 23, 27, 12 }, 35 },
        new object[] { new int[] { 0, 24, 10, 7, 16, 28, 18, 25, 5 }, 84 },
        new object[] { new int[] { 16, 10, 23 }, 39 },
    };
}
