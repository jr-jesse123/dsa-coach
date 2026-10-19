namespace TopCoding.Array.TestData;

public static class P006Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 2, 3, 1, 1, 4 }, true },
        new object[] { new int[] { 3, 2, 1, 0, 4 }, false },
        new object[] { new int[] { 0 }, true },
        new object[] { new int[] { 0, 1 }, false },
        new object[] { new int[] { 1, 0 }, true },
        new object[] { new int[] { 2, 0, 0 }, true },
        new object[] { new int[] { 1, 1, 0, 1 }, false },
        new object[] { new int[] { 100000, 0, 0, 0, 0 }, true },
        new object[] { Enumerable.Repeat(1, 10000).ToArray(), true },
        new object[] { Enumerable.Repeat(1, 9999).Append(0).Prepend(0).ToArray(), false },
        new object[] { Enumerable.Repeat(0, 9999).Prepend(100000).ToArray(), true },
        new object[] { new int[] { 1, 4, 1, 4 }, true },
        new object[] { new int[] { 2, 3, 0, 2, 2 }, true },
        new object[] { new int[] { 4, 2, 2, 3, 1 }, true },
        new object[] { new int[] { 2, 2, 2, 1, 3, 2, 2, 2, 2, 4, 2, 4 }, true },
        new object[] { new int[] { 1, 2, 0, 0 }, true },
        new object[] { new int[] { 4, 4, 3, 4, 0, 3, 4, 3, 0, 1 }, true },
        new object[] { new int[] { 0, 3, 4, 0, 1, 2, 2, 3, 4, 2, 0, 3 }, false },
        new object[] { new int[] { 1, 3, 1, 1, 1, 4, 3, 2, 2, 0, 2, 1 }, true },
        new object[] { new int[] { 4, 0, 0, 4, 1, 2, 4, 3 }, true },
        new object[] { new int[] { 2, 2, 4 }, true },
        new object[] { new int[] { 2, 2, 3, 0, 3, 3, 2, 3 }, true },
        new object[] { new int[] { 1, 2, 2, 0, 4, 4, 3, 1, 3, 3, 1, 3 }, true },
    };
}
