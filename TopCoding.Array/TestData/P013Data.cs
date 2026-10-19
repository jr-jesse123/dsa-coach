namespace TopCoding.Array.TestData;

public static class P013Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }, 3 },
        new object[] { new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 }, -1 },
        new object[] { new int[] { 5 }, new int[] { 4 }, 0 },
        new object[] { new int[] { 2 }, new int[] { 2 }, 0 },
        new object[] { new int[] { 1 }, new int[] { 2 }, -1 },
        new object[] { new int[] { 1, 2 }, new int[] { 2, 1 }, 1 },
        new object[] { new int[] { 2, 0, 0 }, new int[] { 0, 1, 1 }, 0 },
        new object[] { new int[] { 0, 0, 5 }, new int[] { 1, 1, 1 }, 2 },
        new object[] { new int[] { 3, 1, 1 }, new int[] { 1, 2, 2 }, 0 },
        new object[] { Enumerable.Repeat(1, 99999).Append(100).ToArray(), Enumerable.Repeat(2, 100000).ToArray(), -1 },
        new object[] { Enumerable.Repeat(0, 100000).ToArray(), Enumerable.Repeat(1, 100000).ToArray(), -1 },
        new object[] { new int[] { 1, 3, 5, 1, 3, 4, 4, 5 }, new int[] { 6, 6, 0, 3, 2, 0, 3, 6 }, 2 },
        new object[] { new int[] { 2 }, new int[] { 3 }, -1 },
        new object[] { new int[] { 0, 4, 2, 3, 6, 0, 5, 3 }, new int[] { 6, 1, 4, 3, 1, 5, 5, 2 }, -1 },
        new object[] { new int[] { 4, 0, 6, 0, 0, 2, 5, 2 }, new int[] { 4, 1, 1, 4, 5, 5, 6, 3 }, -1 },
        new object[] { new int[] { 5, 0, 3, 1, 0, 6 }, new int[] { 5, 3, 4, 0, 3, 4 }, -1 },
        new object[] { new int[] { 5, 4 }, new int[] { 4, 6 }, -1 },
        new object[] { new int[] { 4, 6, 3, 1 }, new int[] { 0, 6, 6, 4 }, -1 },
        new object[] { new int[] { 2, 2, 6 }, new int[] { 6, 4, 2 }, -1 },
        new object[] { new int[] { 2, 5, 2 }, new int[] { 6, 1, 1 }, 1 },
        new object[] { new int[] { 6, 5, 2, 2, 0, 5, 0 }, new int[] { 6, 4, 2, 6, 6, 0, 3 }, -1 },
        new object[] { new int[] { 2, 3, 4, 4, 4, 3, 1, 1 }, new int[] { 2, 2, 6, 0, 3, 5, 4, 2 }, -1 },
        new object[] { new int[] { 2, 0, 4, 4, 5 }, new int[] { 6, 5, 6, 5, 3 }, -1 },
        new object[] { new int[] { 0, 1, 0, 4 }, new int[] { 1, 1, 5, 3 }, -1 },
        new object[] { new int[] { 0, 6, 4, 5, 0, 5, 0 }, new int[] { 1, 0, 1, 2, 4, 2, 5 }, 1 },
        new object[] { new int[] { 3, 6, 0, 0, 6 }, new int[] { 3, 3, 6, 5, 0 }, -1 },
        new object[] { new int[] { 1, 0, 4, 6, 5 }, new int[] { 2, 4, 5, 0, 3 }, 3 },
        new object[] { new int[] { 4, 4, 1 }, new int[] { 0, 4, 2 }, 0 },
        new object[] { new int[] { 1, 1, 2, 3, 2, 3, 2, 3 }, new int[] { 4, 3, 0, 1, 6, 4, 5, 1 }, -1 },
        new object[] { new int[] { 6, 4, 6, 1, 1 }, new int[] { 3, 3, 3, 5, 4 }, 0 },
        new object[] { new int[] { 2 }, new int[] { 0 }, 0 },
    };
}
