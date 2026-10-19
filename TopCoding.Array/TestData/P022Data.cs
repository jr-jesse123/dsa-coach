namespace TopCoding.Array.TestData;

public static class P022Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 1, 3, 4, 2, 2 }, 2 },
        new object[] { new int[] { 3, 1, 3, 4, 2 }, 3 },
        new object[] { new int[] { 3, 3, 3, 3, 3 }, 3 },
        new object[] { new int[] { 1, 1 }, 1 },
        new object[] { new int[] { 2, 2, 1 }, 2 },
        new object[] { new int[] { 1, 2, 2 }, 2 },
        new object[] { new int[] { 2, 1, 1 }, 1 },
        new object[] { new int[] { 1, 4, 4, 2, 4 }, 4 },
        new object[] { new int[] { 2, 5, 9, 6, 9, 3, 8, 9, 7, 1 }, 9 },
        new object[] { Enumerable.Range(1, 99999).Append(77777).ToArray(), 77777 },
        new object[] { Enumerable.Repeat(99999, 100000).ToArray(), 99999 },
        new object[] { new int[] { 2, 1, 2 }, 2 },
        new object[] { new int[] { 4, 4, 6, 3, 5, 1, 4 }, 4 },
        new object[] { new int[] { 2, 1, 1, 3 }, 1 },
        new object[] { new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 2 },
        new object[] { new int[] { 3, 2, 2, 1 }, 2 },
        new object[] { new int[] { 1, 1, 1, 1, 1, 2, 5, 1, 1, 1 }, 1 },
        new object[] { new int[] { 2, 2, 2 }, 2 },
        new object[] { new int[] { 1, 1, 2 }, 1 },
        new object[] { new int[] { 5, 2, 5, 1, 6, 5, 3 }, 5 },
        new object[] { new int[] { 4, 8, 1, 1, 1, 2, 1, 1, 7, 1 }, 1 },
        new object[] { new int[] { 2, 2, 1, 3 }, 2 },
        new object[] { new int[] { 2, 2, 2, 2, 3 }, 2 },
        new object[] { new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 1 },
        new object[] { new int[] { 2, 2, 2, 2, 2, 2 }, 2 },
        new object[] { new int[] { 1, 2, 1, 4, 1, 1, 1, 1, 1, 5, 1 }, 1 },
        new object[] { new int[] { 2, 7, 2, 6, 4, 2, 5, 3 }, 2 },
        new object[] { new int[] { 4, 4, 4, 4, 4, 7, 4, 2 }, 4 },
        new object[] { new int[] { 2, 4, 2, 2, 2 }, 2 },
        new object[] { new int[] { 4, 4, 4, 4, 4, 4, 4, 4 }, 4 },
        new object[] { new int[] { 7, 1, 1, 8, 6, 1, 3, 4, 2 }, 1 },
        new object[] { new int[] { 3, 1, 3, 2 }, 3 },
        new object[] { new int[] { 2, 1, 3, 2 }, 2 },
        new object[] { new int[] { 5, 3, 5, 1, 5, 4 }, 5 },
        new object[] { new int[] { 3, 7, 3, 3, 5, 3, 2, 8, 3 }, 3 },
        new object[] { new int[] { 7, 7, 4, 3, 2, 7, 7, 7, 7 }, 7 },
    };
}
