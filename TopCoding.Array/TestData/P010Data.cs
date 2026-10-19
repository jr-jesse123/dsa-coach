namespace TopCoding.Array.TestData;

public static class P010Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 3, true },
        new object[] { new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 13, false },
        new object[] { new int[][] { new int[] { 1 } }, 1, true },
        new object[] { new int[][] { new int[] { 1 } }, 2, false },
        new object[] { new int[][] { new int[] { 1, 3 } }, 3, true },
        new object[] { new int[][] { new int[] { 1 }, new int[] { 3 } }, 3, true },
        new object[] { new int[][] { new int[] { 1 }, new int[] { 3 } }, 0, false },
        new object[] { new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 1, true },
        new object[] { new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 60, true },
        new object[] { new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 61, false },
        new object[] { new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 0, false },
        new object[] { new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } }, 23, true },
        new object[] { new int[][] { new int[] { -10000, 10000 } }, -10000, true },
        new object[] { new int[][] { new int[] { -10000, 10000 } }, 10000, true },
        new object[] { new int[][] { new int[] { -50, -49, -46, -40 }, new int[] { -33, -30, -25, -20 }, new int[] { -19, -13, -5, -3 }, new int[] { 1, 2, 9, 13 }, new int[] { 16, 23, 26, 31 }, new int[] { 36, 38, 42, 45 } }, 1, true },
        new object[] { new int[][] { new int[] { -45, -39, -34 }, new int[] { -20, -13, -1 }, new int[] { 23, 26, 44 } }, -7, false },
        new object[] { new int[][] { new int[] { -50, -44, -26, -8, 3 }, new int[] { 11, 17, 19, 26, 45 } }, -44, true },
        new object[] { new int[][] { new int[] { -49, -43, -38, -34, -30, -29 }, new int[] { -28, -26, -24, -23, -19, -17 }, new int[] { -3, -2, 1, 4, 5, 9 }, new int[] { 12, 13, 14, 15, 17, 21 }, new int[] { 31, 35, 37, 38, 41, 42 } }, -2, true },
        new object[] { new int[][] { new int[] { -33 }, new int[] { -13 }, new int[] { 0 }, new int[] { 27 } }, -13, true },
        new object[] { new int[][] { new int[] { -48, -26, 25, 28 } }, 36, false },
        new object[] { new int[][] { new int[] { -48, -46, -35, -33, -32, -31 }, new int[] { -18, -12, -11, -10, -8, -5 }, new int[] { -4, 10, 14, 21, 27, 34 }, new int[] { 37, 41, 42, 44, 47, 49 } }, -4, true },
        new object[] { new int[][] { new int[] { -32, -17, 13 }, new int[] { 15, 24, 41 } }, 0, false },
        new object[] { new int[][] { new int[] { -36, -30, -26, -21, -18 }, new int[] { -8, -4, 0, 1, 3 }, new int[] { 10, 14, 17, 21, 25 }, new int[] { 29, 31, 35, 43, 50 } }, 31, true },
        new object[] { new int[][] { new int[] { -47, -13, -5, 1 }, new int[] { 2, 10, 31, 33 } }, 1, true },
        new object[] { new int[][] { new int[] { 44 } }, 44, true },
        new object[] { new int[][] { new int[] { -50, -40, -39, -34 }, new int[] { -28, -26, -15, -14 }, new int[] { -7, -3, 0, 12 }, new int[] { 21, 23, 31, 37 }, new int[] { 38, 40, 41, 48 } }, 18, false },
        new object[] { new int[][] { new int[] { -38, -37, -30, -28, -27, -26 }, new int[] { -23, -18, -15, -14, -12, -9 }, new int[] { 5, 9, 18, 28, 29, 48 } }, -9, true },
        new object[] { new int[][] { new int[] { -35, -30 }, new int[] { -6, -5 }, new int[] { 1, 39 } }, 5, false },
        new object[] { new int[][] { new int[] { -43 }, new int[] { 0 }, new int[] { 1 }, new int[] { 40 } }, -43, true },
    };
}
