namespace TopCoding.Array.TestData;

public static class P027Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 1, 3 } }, 1 },
        new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { 1, 2 } }, 2 },
        new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 1 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 2 }, new int[] { 1, 3 } }, 1 },
        new object[] { new int[][] { new int[] { 1, 100 }, new int[] { 11, 22 }, new int[] { 1, 11 }, new int[] { 2, 12 } }, 2 },
        new object[] { new int[][] { new int[] { 0, 2 }, new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 3, 5 }, new int[] { 4, 6 } }, 2 },
        new object[] { new int[][] { new int[] { -50000, 50000 }, new int[] { -50000, 0 }, new int[] { 0, 50000 } }, 1 },
        new object[] { new int[][] { new int[] { 1, 5 }, new int[] { 2, 3 }, new int[] { 3, 4 } }, 1 },
        new object[] { Enumerable.Range(0, 100000).Select(i => new[] { i - 50000, i - 49999 }).ToArray(), 0 },
        new object[] { Enumerable.Range(0, 100000).Select(i => new[] { -50000, -49999 + i % 100000 / 2 }).ToArray(), 99999 },
        new object[] { new int[][] { new int[] { 10, 15 } }, 0 },
        new object[] { new int[][] { new int[] { -1, 4 }, new int[] { -3, 2 }, new int[] { -3, 0 }, new int[] { -1, 1 }, new int[] { 4, 6 } }, 3 },
        new object[] { new int[][] { new int[] { -3, -2 }, new int[] { 8, 13 }, new int[] { 7, 9 }, new int[] { 1, 6 }, new int[] { -3, 2 } }, 2 },
        new object[] { new int[][] { new int[] { -4, 0 }, new int[] { 9, 13 }, new int[] { 2, 7 }, new int[] { 6, 7 } }, 1 },
        new object[] { new int[][] { new int[] { 0, 3 }, new int[] { 9, 13 }, new int[] { 2, 3 }, new int[] { 5, 10 }, new int[] { 3, 4 }, new int[] { -4, -3 } }, 2 },
        new object[] { new int[][] { new int[] { 0, 5 }, new int[] { -4, 1 }, new int[] { -5, -1 }, new int[] { -4, -3 }, new int[] { 6, 11 }, new int[] { 8, 9 }, new int[] { -2, 2 } }, 4 },
        new object[] { new int[][] { new int[] { -4, -1 }, new int[] { 7, 8 }, new int[] { -3, 1 } }, 1 },
        new object[] { new int[][] { new int[] { 2, 5 }, new int[] { 2, 7 }, new int[] { -3, -2 }, new int[] { 9, 12 } }, 1 },
        new object[] { new int[][] { new int[] { -2, 2 }, new int[] { 9, 12 }, new int[] { 3, 6 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 4 }, new int[] { 9, 14 }, new int[] { 6, 8 } }, 0 },
        new object[] { new int[][] { new int[] { 3, 8 } }, 0 },
        new object[] { new int[][] { new int[] { 6, 9 }, new int[] { -5, -3 } }, 0 },
        new object[] { new int[][] { new int[] { -4, -3 }, new int[] { -3, 0 }, new int[] { -5, -4 }, new int[] { 6, 7 }, new int[] { 5, 7 } }, 1 },
        new object[] { new int[][] { new int[] { 9, 14 }, new int[] { 3, 7 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 5 }, new int[] { 3, 5 }, new int[] { 10, 14 }, new int[] { 10, 15 }, new int[] { 9, 11 } }, 3 },
        new object[] { new int[][] { new int[] { -5, -2 }, new int[] { -1, 2 }, new int[] { 2, 5 }, new int[] { 4, 6 }, new int[] { 2, 7 } }, 2 },
        new object[] { new int[][] { new int[] { -5, -2 } }, 0 },
        new object[] { new int[][] { new int[] { 1, 5 }, new int[] { -5, -1 }, new int[] { 5, 7 }, new int[] { -2, -1 } }, 1 },
        new object[] { new int[][] { new int[] { -4, 0 }, new int[] { 0, 4 }, new int[] { 10, 14 }, new int[] { 6, 11 } }, 1 },
        new object[] { new int[][] { new int[] { -3, 2 } }, 0 },
        new object[] { new int[][] { new int[] { 3, 8 }, new int[] { 0, 1 }, new int[] { 10, 11 } }, 0 },
        new object[] { new int[][] { new int[] { 5, 6 }, new int[] { 1, 4 }, new int[] { 6, 8 } }, 0 },
        new object[] { new int[][] { new int[] { -4, 1 }, new int[] { -4, -1 }, new int[] { 4, 7 }, new int[] { 6, 9 }, new int[] { -1, 4 }, new int[] { -2, 1 }, new int[] { 4, 7 } }, 4 },
        new object[] { new int[][] { new int[] { -2, 1 }, new int[] { 7, 9 }, new int[] { 6, 7 }, new int[] { 5, 9 } }, 1 },
        new object[] { new int[][] { new int[] { 8, 12 }, new int[] { 10, 12 }, new int[] { 7, 8 } }, 1 },
    };
}
