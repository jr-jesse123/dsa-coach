namespace TopCoding.Array.TestData;

public static class P011Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[][] { new int[] { 2 }, new int[] { 3, 4 }, new int[] { 6, 5, 7 }, new int[] { 4, 1, 8, 3 } }, 11 },
        new object[] { new int[][] { new int[] { -10 } }, -10 },
        new object[] { new int[][] { new int[] { 0 } }, 0 },
        new object[] { new int[][] { new int[] { 1 }, new int[] { 2, 3 } }, 3 },
        new object[] { new int[][] { new int[] { -1 }, new int[] { -2, -3 } }, -4 },
        new object[] { new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 1, 1 } }, 3 },
        new object[] { new int[][] { new int[] { 10000 }, new int[] { -10000, 10000 } }, 0 },
        new object[] { new int[][] { new int[] { 1 }, new int[] { 100, 2 }, new int[] { 100, 100, 3 }, new int[] { 100, 100, 100, 4 } }, 10 },
        new object[] { Enumerable.Range(1, 200).Select(i => Enumerable.Range(0, i).Select(j => (i * 31 + j * 17) % 201 - 100).ToArray()).ToArray(), -4640 },
        new object[] { new int[][] { new int[] { -15 }, new int[] { -7, 6 }, new int[] { 19, 1, 18 }, new int[] { 1, 8, 13, -6 }, new int[] { 11, -5, -1, 8, -6 }, new int[] { -17, 8, -4, -2, 15, 17 }, new int[] { -18, -17, 4, 15, 17, 1, -6 } }, -27 },
        new object[] { new int[][] { new int[] { 8 } }, 8 },
        new object[] { new int[][] { new int[] { 7 }, new int[] { -12, 14 }, new int[] { 0, 1, -7 } }, -5 },
        new object[] { new int[][] { new int[] { 19 }, new int[] { -18, -18 }, new int[] { -1, 10, -3 }, new int[] { 13, 0, -6, -6 }, new int[] { -10, 17, -2, 0, 4 }, new int[] { -20, -14, 14, 5, -11, 8 }, new int[] { 12, -18, -1, 4, -5, -6, -16 } }, -35 },
        new object[] { new int[][] { new int[] { 19 }, new int[] { -13, 7 }, new int[] { 12, 19, -16 }, new int[] { 15, 11, -19, -4 }, new int[] { -20, 3, 17, -16, -9 }, new int[] { 10, 1, -8, -20, 3, 6 }, new int[] { 17, -18, 17, -18, 12, 12, -20 } }, -63 },
        new object[] { new int[][] { new int[] { 17 }, new int[] { -15, -7 }, new int[] { 17, 18, -16 }, new int[] { -3, 18, -8, 8 }, new int[] { 17, 17, -18, -4, 12 }, new int[] { -7, -10, -19, 18, -1, 0 }, new int[] { 10, -18, -2, 16, -10, -17, 16 }, new int[] { 0, 1, 7, 18, -5, -3, -13, 6 } }, -49 },
        new object[] { new int[][] { new int[] { -13 }, new int[] { -19, -20 }, new int[] { -14, 0, 19 } }, -46 },
        new object[] { new int[][] { new int[] { 16 }, new int[] { -15, -12 }, new int[] { -16, -12, -13 }, new int[] { 0, -13, -18, -15 }, new int[] { 13, -6, -19, 7, -14 }, new int[] { 4, -12, -10, -15, -16, 9 } }, -63 },
        new object[] { new int[][] { new int[] { 3 }, new int[] { 12, -7 } }, -4 },
        new object[] { new int[][] { new int[] { 19 }, new int[] { -14, 11 }, new int[] { -6, -10, 14 }, new int[] { -12, 18, 0, 18 } }, -13 },
        new object[] { new int[][] { new int[] { 3 }, new int[] { 18, 11 }, new int[] { 0, 7, -16 }, new int[] { -19, -10, -18, -17 }, new int[] { 18, -2, 12, 6, -19 }, new int[] { -19, -17, 13, -3, 18, 8 }, new int[] { 15, -17, 15, -4, 6, -6, 16 } }, -36 },
        new object[] { new int[][] { new int[] { -13 }, new int[] { 11, -6 }, new int[] { -9, -9, 19 } }, -28 },
        new object[] { new int[][] { new int[] { -12 }, new int[] { 2, -3 }, new int[] { -2, 9, 14 }, new int[] { -12, 16, -8, 13 }, new int[] { -2, 7, 5, 6, 2 }, new int[] { 14, -17, -20, 2, 11, -16 }, new int[] { 16, -17, 2, -6, 18, 8, 14 }, new int[] { -3, -18, 13, -12, -12, -7, -4, -7 } }, -78 },
        new object[] { new int[][] { new int[] { -4 }, new int[] { -2, 12 }, new int[] { -9, -13, 7 }, new int[] { 0, 3, -10, -20 }, new int[] { 16, -17, -3, -3, -1 }, new int[] { -16, -13, -13, 19, -19, 18 } }, -51 },
        new object[] { new int[][] { new int[] { -6 }, new int[] { -14, 9 }, new int[] { -4, -8, 8 }, new int[] { 4, -5, 6, 15 } }, -33 },
    };
}
