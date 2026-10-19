namespace TopCoding.Array.TestData;

public static class P039Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[][] { new int[] { 3, 0, 8, 4 }, new int[] { 2, 4, 5, 7 }, new int[] { 9, 2, 6, 3 }, new int[] { 0, 3, 1, 0 } }, 35 },
        new object[] { new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } }, 0 },
        new object[] { new int[][] { new int[] { 1, 1 }, new int[] { 1, 1 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 100 }, new int[] { 100, 0 } }, 200 },
        new object[] { new int[][] { new int[] { 100, 100 }, new int[] { 100, 100 } }, 0 },
        new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } }, 1 },
        new object[] { new int[][] { new int[] { 0, 0 }, new int[] { 0, 5 } }, 0 },
        new object[] { new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }, 6 },
        new object[] { Enumerable.Range(0, 50).Select(i => Enumerable.Range(0, 50).Select(j => (i * j) % 101).ToArray()).ToArray(), 110404 },
        new object[] { Enumerable.Range(0, 50).Select(i => Enumerable.Repeat(100, 50).ToArray()).ToArray(), 0 },
        new object[] { new int[][] { new int[] { 9, 14, 6, 10, 18 }, new int[] { 4, 6, 2, 7, 11 }, new int[] { 1, 0, 13, 14, 16 }, new int[] { 14, 18, 0, 15, 12 }, new int[] { 7, 11, 2, 8, 18 } }, 127 },
        new object[] { new int[][] { new int[] { 1, 3, 17, 7, 8, 8 }, new int[] { 16, 10, 2, 15, 12, 6 }, new int[] { 19, 7, 2, 5, 6, 0 }, new int[] { 1, 14, 3, 5, 18, 5 }, new int[] { 10, 14, 8, 12, 19, 19 }, new int[] { 2, 15, 12, 9, 5, 17 } }, 267 },
        new object[] { new int[][] { new int[] { 14, 11 }, new int[] { 11, 6 } }, 5 },
        new object[] { new int[][] { new int[] { 9, 2, 14, 20, 16, 2 }, new int[] { 13, 11, 5, 15, 4, 0 }, new int[] { 2, 9, 20, 7, 0, 9 }, new int[] { 2, 15, 2, 0, 10, 9 }, new int[] { 1, 0, 17, 20, 3, 19 }, new int[] { 1, 19, 12, 18, 9, 19 } }, 268 },
        new object[] { new int[][] { new int[] { 16, 16, 10 }, new int[] { 18, 11, 2 }, new int[] { 19, 19, 16 } }, 27 },
        new object[] { new int[][] { new int[] { 18, 9, 10, 9, 15 }, new int[] { 16, 3, 12, 18, 9 }, new int[] { 14, 10, 10, 12, 3 }, new int[] { 3, 9, 8, 6, 18 }, new int[] { 6, 10, 5, 0, 5 } }, 104 },
        new object[] { new int[][] { new int[] { 7, 19, 20, 20, 8 }, new int[] { 14, 2, 2, 3, 10 }, new int[] { 19, 8, 20, 3, 16 }, new int[] { 19, 2, 8, 16, 4 }, new int[] { 1, 8, 5, 9, 15 } }, 167 },
        new object[] { new int[][] { new int[] { 15, 19, 20, 10 }, new int[] { 2, 0, 2, 8 }, new int[] { 17, 4, 11, 5 }, new int[] { 15, 16, 0, 2 } }, 71 },
        new object[] { new int[][] { new int[] { 17, 11, 2, 8, 17, 3 }, new int[] { 11, 7, 17, 6, 3, 16 }, new int[] { 5, 12, 14, 18, 14, 15 }, new int[] { 20, 19, 10, 7, 5, 11 }, new int[] { 17, 19, 9, 12, 12, 14 }, new int[] { 5, 16, 10, 7, 7, 6 } }, 213 },
        new object[] { new int[][] { new int[] { 6, 20, 5, 0, 11 }, new int[] { 12, 1, 5, 9, 6 }, new int[] { 15, 18, 14, 19, 9 }, new int[] { 19, 4, 4, 20, 15 }, new int[] { 10, 6, 4, 16, 18 } }, 151 },
        new object[] { new int[][] { new int[] { 8, 9, 9, 13 }, new int[] { 7, 12, 13, 11 }, new int[] { 14, 15, 18, 7 }, new int[] { 13, 2, 19, 6 } }, 49 },
        new object[] { new int[][] { new int[] { 20, 6, 6 }, new int[] { 4, 11, 11 }, new int[] { 4, 2, 3 } }, 20 },
        new object[] { new int[][] { new int[] { 3, 17, 5 }, new int[] { 11, 14, 16 }, new int[] { 9, 12, 12 } }, 23 },
        new object[] { new int[][] { new int[] { 9, 4, 1, 4, 3, 0 }, new int[] { 0, 1, 6, 12, 9, 2 }, new int[] { 15, 11, 17, 16, 11, 2 }, new int[] { 4, 7, 20, 15, 6, 7 }, new int[] { 4, 13, 15, 15, 1, 12 }, new int[] { 7, 5, 11, 12, 9, 6 } }, 156 },
        new object[] { new int[][] { new int[] { 13, 15, 16, 11 }, new int[] { 14, 6, 20, 2 }, new int[] { 4, 13, 0, 13 }, new int[] { 3, 3, 20, 6 } }, 75 },
        new object[] { new int[][] { new int[] { 3, 10, 3 }, new int[] { 19, 2, 9 }, new int[] { 10, 19, 2 } }, 46 },
        new object[] { new int[][] { new int[] { 19, 4, 17, 18, 13 }, new int[] { 14, 18, 19, 0, 20 }, new int[] { 19, 14, 2, 3, 18 }, new int[] { 17, 13, 8, 7, 4 }, new int[] { 15, 19, 18, 7, 1 } }, 155 },
        new object[] { new int[][] { new int[] { 16, 15, 10 }, new int[] { 6, 20, 14 }, new int[] { 8, 2, 6 } }, 23 },
        new object[] { new int[][] { new int[] { 6, 9, 4, 10, 3, 15 }, new int[] { 7, 14, 9, 14, 13, 0 }, new int[] { 8, 19, 4, 4, 19, 13 }, new int[] { 13, 8, 4, 9, 4, 20 }, new int[] { 13, 4, 7, 7, 16, 16 }, new int[] { 9, 3, 6, 20, 18, 12 } }, 184 },
        new object[] { new int[][] { new int[] { 13, 0, 17, 0 }, new int[] { 0, 19, 18, 2 }, new int[] { 14, 16, 11, 6 }, new int[] { 8, 4, 10, 15 } }, 96 },
    };
}
