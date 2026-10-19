namespace TopCoding.Array.TestData;

public static class P008Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 0 } }, 2 },
        new object[] { new int[][] { new int[] { 0, 1 }, new int[] { 0, 0 } }, 1 },
        new object[] { new int[][] { new int[] { 1 } }, 0 },
        new object[] { new int[][] { new int[] { 0 } }, 1 },
        new object[] { new int[][] { new int[] { 0, 0 }, new int[] { 0, 1 } }, 0 },
        new object[] { new int[][] { new int[] { 1, 0 }, new int[] { 0, 0 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 0, 0, 0 } }, 1 },
        new object[] { new int[][] { new int[] { 0 }, new int[] { 0 }, new int[] { 1 }, new int[] { 0 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } }, 155117520 },
        new object[] { new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } }, 6 },
        new object[] { new int[][] { new int[] { 0, 0, 0, 1 }, new int[] { 1, 0, 0, 0 }, new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 0 }, new int[] { 0, 1, 0, 0 }, new int[] { 1, 0, 1, 0 } }, 8 },
        new object[] { new int[][] { new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 } }, 6 },
        new object[] { new int[][] { new int[] { 0, 1, 0, 0, 0 }, new int[] { 0, 0, 1, 1, 0 }, new int[] { 0, 1, 0, 0, 1 }, new int[] { 0, 0, 0, 0, 0 }, new int[] { 1, 0, 1, 0, 0 }, new int[] { 0, 1, 0, 1, 0 } }, 2 },
        new object[] { new int[][] { new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 } }, 56 },
        new object[] { new int[][] { new int[] { 1 }, new int[] { 1 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 }, new int[] { 0, 0 } }, 6 },
        new object[] { new int[][] { new int[] { 0, 0, 0, 1, 0, 1 } }, 0 },
        new object[] { new int[][] { new int[] { 1, 0, 0, 0 }, new int[] { 1, 0, 1, 1 }, new int[] { 1, 0, 1, 0 } }, 0 },
        new object[] { new int[][] { new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 } }, 1 },
        new object[] { new int[][] { new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 } }, 56 },
        new object[] { new int[][] { new int[] { 1, 1, 0, 0, 1, 0 }, new int[] { 0, 1, 0, 1, 1, 1 }, new int[] { 0, 0, 1, 1, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 1, 0, 1, 0, 1, 1 }, new int[] { 1, 0, 0, 0, 1, 0 } }, 0 },
        new object[] { new int[][] { new int[] { 1, 0, 0, 0, 0, 0 }, new int[] { 1, 0, 0, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0, 1 }, new int[] { 0, 0, 0, 1, 0, 1 } }, 0 },
        new object[] { new int[][] { new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 } }, 1 },
        new object[] { new int[][] { new int[] { 0 }, new int[] { 1 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 }, new int[] { 0 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 0, 1, 0, 0 } }, 0 },
        new object[] { new int[][] { new int[] { 0 }, new int[] { 0 } }, 1 },
        new object[] { new int[][] { new int[] { 0, 0, 1 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 1 }, new int[] { 0, 0, 0 } }, 4 },
        new object[] { new int[][] { new int[] { 0 }, new int[] { 1 } }, 0 },
        new object[] { new int[][] { new int[] { 0, 0 }, new int[] { 0, 0 } }, 2 },
        new object[] { new int[][] { new int[] { 0, 0 } }, 1 },
    };
}
