namespace TopCoding.Array.TestData;

public static class P009Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[][] { new int[] { 1, 3, 1 }, new int[] { 1, 5, 1 }, new int[] { 4, 2, 1 } }, 7 },
        new object[] { new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } }, 12 },
        new object[] { new int[][] { new int[] { 0 } }, 0 },
        new object[] { new int[][] { new int[] { 7 } }, 7 },
        new object[] { new int[][] { new int[] { 1, 2, 3 } }, 6 },
        new object[] { new int[][] { new int[] { 1 }, new int[] { 2 }, new int[] { 3 } }, 6 },
        new object[] { new int[][] { new int[] { 0, 0 }, new int[] { 0, 0 } }, 0 },
        new object[] { new int[][] { new int[] { 200, 200 }, new int[] { 200, 200 } }, 600 },
        new object[] { new int[][] { new int[] { 1, 100, 1 }, new int[] { 1, 100, 1 }, new int[] { 1, 1, 1 } }, 5 },
        new object[] { Enumerable.Range(0, 200).Select(i => Enumerable.Range(0, 200).Select(j => (i * j) % 201).ToArray()).ToArray(), 10631 },
        new object[] { new int[][] { new int[] { 3, 7, 11 }, new int[] { 17, 10, 14 }, new int[] { 12, 12, 9 } }, 41 },
        new object[] { new int[][] { new int[] { 20, 0, 11 }, new int[] { 15, 16, 11 }, new int[] { 15, 6, 1 } }, 43 },
        new object[] { new int[][] { new int[] { 16, 13, 6, 13 }, new int[] { 12, 12, 10, 1 }, new int[] { 16, 12, 13, 10 }, new int[] { 8, 6, 1, 14 } }, 70 },
        new object[] { new int[][] { new int[] { 8, 7, 7, 19 } }, 41 },
        new object[] { new int[][] { new int[] { 13 }, new int[] { 13 }, new int[] { 17 }, new int[] { 2 }, new int[] { 18 } }, 63 },
        new object[] { new int[][] { new int[] { 0, 12 }, new int[] { 18, 15 }, new int[] { 4, 4 }, new int[] { 12, 19 }, new int[] { 11, 17 } }, 62 },
        new object[] { new int[][] { new int[] { 6, 5, 13, 7 } }, 31 },
        new object[] { new int[][] { new int[] { 2, 8, 2, 10 }, new int[] { 9, 9, 8, 16 }, new int[] { 19, 11, 10, 18 }, new int[] { 2, 3, 6, 16 }, new int[] { 13, 20, 7, 6 } }, 49 },
        new object[] { new int[][] { new int[] { 11, 7, 17, 13 } }, 48 },
        new object[] { new int[][] { new int[] { 2, 8 }, new int[] { 2, 16 }, new int[] { 8, 0 }, new int[] { 0, 7 } }, 19 },
        new object[] { new int[][] { new int[] { 13, 20, 0, 15, 14 }, new int[] { 3, 5, 8, 4, 3 }, new int[] { 19, 18, 9, 16, 1 }, new int[] { 4, 4, 3, 8, 3 } }, 40 },
        new object[] { new int[][] { new int[] { 7 }, new int[] { 1 }, new int[] { 18 }, new int[] { 14 } }, 40 },
        new object[] { new int[][] { new int[] { 4, 9 }, new int[] { 5, 13 }, new int[] { 20, 9 }, new int[] { 9, 7 } }, 38 },
        new object[] { new int[][] { new int[] { 8, 0, 15 }, new int[] { 16, 11, 9 }, new int[] { 9, 1, 8 }, new int[] { 20, 8, 3 }, new int[] { 18, 4, 12 } }, 43 },
        new object[] { new int[][] { new int[] { 20, 7, 18 }, new int[] { 19, 18, 20 } }, 65 },
    };
}
