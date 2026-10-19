namespace TopCoding.Array.TestData;

public static class P001Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49 },
        new object[] { new int[] { 1, 1 }, 1 },
        new object[] { new int[] { 0, 0 }, 0 },
        new object[] { new int[] { 0, 5, 0 }, 0 },
        new object[] { new int[] { 5, 5, 5, 5, 5 }, 20 },
        new object[] { new int[] { 10000, 1, 1, 1, 10000 }, 40000 },
        new object[] { new int[] { 1, 2, 3, 4, 5, 6 }, 9 },
        new object[] { new int[] { 6, 5, 4, 3, 2, 1 }, 9 },
        new object[] { Enumerable.Range(0, 100000).Select(i => i % 10001).ToArray(), 899189910 },
        new object[] { Enumerable.Repeat(10000, 100000).ToArray(), 999990000 },
        new object[] { new int[] { 15, 5, 11, 14, 13, 1, 0, 10, 12, 17, 17, 19 }, 165 },
        new object[] { new int[] { 17, 3, 12, 10, 16 }, 64 },
        new object[] { new int[] { 2, 8, 16, 1, 11, 17, 0, 16, 19, 10, 0, 8 }, 96 },
        new object[] { new int[] { 4, 16, 16, 13 }, 26 },
        new object[] { new int[] { 15, 4, 3, 20, 15, 13, 5, 3 }, 65 },
        new object[] { new int[] { 13, 20, 5, 8, 2, 20, 9, 9, 14 }, 104 },
        new object[] { new int[] { 7, 3, 14, 4 }, 14 },
        new object[] { new int[] { 15, 17, 3, 19, 7, 1, 10, 10, 17, 12 }, 120 },
        new object[] { new int[] { 16, 15 }, 15 },
        new object[] { new int[] { 8, 9, 19, 14, 13, 4, 6, 0, 16, 4, 2, 10 }, 96 },
        new object[] { new int[] { 6, 7, 17 }, 12 },
        new object[] { new int[] { 12, 6, 9 }, 18 },
    };
}
