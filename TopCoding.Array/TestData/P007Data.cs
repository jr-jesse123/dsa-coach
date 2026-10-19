namespace TopCoding.Array.TestData;

public static class P007Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } }, new int[][] { new int[] { 1, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } } },
        new object[] { new int[][] { new int[] { 1, 4 }, new int[] { 4, 5 } }, new int[][] { new int[] { 1, 5 } } },
        new object[] { new int[][] { new int[] { 1, 1 } }, new int[][] { new int[] { 1, 1 } } },
        new object[] { new int[][] { new int[] { 1, 4 }, new int[] { 0, 4 } }, new int[][] { new int[] { 0, 4 } } },
        new object[] { new int[][] { new int[] { 1, 4 }, new int[] { 2, 3 } }, new int[][] { new int[] { 1, 4 } } },
        new object[] { new int[][] { new int[] { 0, 0 }, new int[] { 1, 1 } }, new int[][] { new int[] { 0, 0 }, new int[] { 1, 1 } } },
        new object[] { new int[][] { new int[] { 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7 }, new int[] { 8, 9 }, new int[] { 1, 10 } }, new int[][] { new int[] { 1, 10 } } },
        new object[] { new int[][] { new int[] { 5, 6 }, new int[] { 1, 2 }, new int[] { 3, 4 } }, new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } } },
        new object[] { new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 } }, new int[][] { new int[] { 1, 4 } } },
        new object[] { new int[][] { new int[] { 0, 10000 } }, new int[][] { new int[] { 0, 10000 } } },
        new object[] { new int[][] { new int[] { 10, 12 } }, new int[][] { new int[] { 10, 12 } } },
        new object[] { new int[][] { new int[] { 4, 7 }, new int[] { 9, 11 }, new int[] { 8, 8 }, new int[] { 11, 12 }, new int[] { 18, 21 }, new int[] { 7, 11 }, new int[] { 13, 13 }, new int[] { 4, 8 } }, new int[][] { new int[] { 4, 12 }, new int[] { 13, 13 }, new int[] { 18, 21 } } },
        new object[] { new int[][] { new int[] { 19, 22 }, new int[] { 2, 5 }, new int[] { 2, 6 }, new int[] { 15, 20 }, new int[] { 3, 4 } }, new int[][] { new int[] { 2, 6 }, new int[] { 15, 22 } } },
        new object[] { new int[][] { new int[] { 2, 3 }, new int[] { 9, 14 }, new int[] { 5, 7 }, new int[] { 20, 20 }, new int[] { 10, 11 }, new int[] { 18, 20 } }, new int[][] { new int[] { 2, 3 }, new int[] { 5, 7 }, new int[] { 9, 14 }, new int[] { 18, 20 } } },
        new object[] { new int[][] { new int[] { 15, 16 }, new int[] { 16, 21 }, new int[] { 5, 10 }, new int[] { 19, 23 }, new int[] { 0, 4 }, new int[] { 3, 3 } }, new int[][] { new int[] { 0, 4 }, new int[] { 5, 10 }, new int[] { 15, 23 } } },
        new object[] { new int[][] { new int[] { 15, 16 }, new int[] { 1, 6 }, new int[] { 11, 11 } }, new int[][] { new int[] { 1, 6 }, new int[] { 11, 11 }, new int[] { 15, 16 } } },
        new object[] { new int[][] { new int[] { 8, 10 }, new int[] { 2, 7 } }, new int[][] { new int[] { 2, 7 }, new int[] { 8, 10 } } },
        new object[] { new int[][] { new int[] { 6, 7 }, new int[] { 10, 11 }, new int[] { 10, 13 } }, new int[][] { new int[] { 6, 7 }, new int[] { 10, 13 } } },
        new object[] { new int[][] { new int[] { 15, 15 }, new int[] { 10, 12 }, new int[] { 8, 10 } }, new int[][] { new int[] { 8, 12 }, new int[] { 15, 15 } } },
        new object[] { new int[][] { new int[] { 7, 8 }, new int[] { 18, 18 }, new int[] { 18, 22 }, new int[] { 1, 2 }, new int[] { 15, 19 }, new int[] { 15, 19 }, new int[] { 2, 2 }, new int[] { 6, 11 } }, new int[][] { new int[] { 1, 2 }, new int[] { 6, 11 }, new int[] { 15, 22 } } },
        new object[] { new int[][] { new int[] { 12, 14 }, new int[] { 20, 23 }, new int[] { 6, 8 }, new int[] { 14, 17 }, new int[] { 0, 2 }, new int[] { 10, 13 }, new int[] { 9, 10 }, new int[] { 16, 18 } }, new int[][] { new int[] { 0, 2 }, new int[] { 6, 8 }, new int[] { 9, 18 }, new int[] { 20, 23 } } },
        new object[] { new int[][] { new int[] { 19, 23 }, new int[] { 12, 15 }, new int[] { 0, 3 }, new int[] { 18, 18 } }, new int[][] { new int[] { 0, 3 }, new int[] { 12, 15 }, new int[] { 18, 18 }, new int[] { 19, 23 } } },
        new object[] { new int[][] { new int[] { 13, 17 }, new int[] { 12, 13 } }, new int[][] { new int[] { 12, 17 } } },
        new object[] { new int[][] { new int[] { 2, 3 }, new int[] { 0, 5 }, new int[] { 7, 11 } }, new int[][] { new int[] { 0, 5 }, new int[] { 7, 11 } } },
        new object[] { new int[][] { new int[] { 11, 12 }, new int[] { 8, 10 }, new int[] { 11, 16 }, new int[] { 14, 15 } }, new int[][] { new int[] { 8, 10 }, new int[] { 11, 16 } } },
        new object[] { new int[][] { new int[] { 3, 3 }, new int[] { 18, 19 } }, new int[][] { new int[] { 3, 3 }, new int[] { 18, 19 } } },
        new object[] { new int[][] { new int[] { 13, 16 }, new int[] { 12, 15 }, new int[] { 8, 13 }, new int[] { 4, 8 }, new int[] { 7, 7 }, new int[] { 18, 18 }, new int[] { 14, 17 } }, new int[][] { new int[] { 4, 17 }, new int[] { 18, 18 } } },
        new object[] { new int[][] { new int[] { 4, 8 }, new int[] { 6, 8 }, new int[] { 3, 3 }, new int[] { 1, 5 }, new int[] { 16, 16 } }, new int[][] { new int[] { 1, 8 }, new int[] { 16, 16 } } },
        new object[] { new int[][] { new int[] { 13, 14 }, new int[] { 1, 2 }, new int[] { 6, 8 }, new int[] { 1, 4 } }, new int[][] { new int[] { 1, 4 }, new int[] { 6, 8 }, new int[] { 13, 14 } } },
        new object[] { new int[][] { new int[] { 9, 10 } }, new int[][] { new int[] { 9, 10 } } },
    };
}
