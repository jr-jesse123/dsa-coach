namespace TopCoding.Array.TestData;

public static class P020Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new char[][] { new char[] { '1', '0', '1', '0', '0' }, new char[] { '1', '0', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1' }, new char[] { '1', '0', '0', '1', '0' } }, 4 },
        new object[] { new char[][] { new char[] { '0', '1' }, new char[] { '1', '0' } }, 1 },
        new object[] { new char[][] { new char[] { '0' } }, 0 },
        new object[] { new char[][] { new char[] { '1' } }, 1 },
        new object[] { new char[][] { new char[] { '1', '1' }, new char[] { '1', '1' } }, 4 },
        new object[] { new char[][] { new char[] { '1', '1', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '1' }, new char[] { '1' }, new char[] { '1' } }, 1 },
        new object[] { new char[][] { new char[] { '1', '1', '1' }, new char[] { '1', '1', '1' }, new char[] { '1', '1', '0' } }, 4 },
        new object[] { new char[][] { new char[] { '0', '0' }, new char[] { '0', '0' } }, 0 },
        new object[] { new char[][] { new char[] { '1', '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1', '1' } }, 64 },
        new object[] { new char[][] { new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '1', '0', '1', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '1', '0' }, new char[] { '1', '1' }, new char[] { '0', '1' }, new char[] { '0', '0' }, new char[] { '1', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '1', '0', '0' }, new char[] { '1', '0', '1' }, new char[] { '0', '1', '0' }, new char[] { '0', '1', '1' }, new char[] { '0', '0', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '1', '1', '1' }, new char[] { '1', '0', '0', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '1', '1', '0', '1', '1', '1', '1' }, new char[] { '1', '1', '0', '1', '1', '0', '1' }, new char[] { '1', '1', '1', '1', '1', '0', '0' }, new char[] { '1', '1', '1', '0', '0', '1', '1' } }, 4 },
        new object[] { new char[][] { new char[] { '0', '0', '0', '0', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '1', '0', '0' }, new char[] { '1', '0', '0', '0', '0', '1', '0' }, new char[] { '1', '0', '1', '0', '0', '0', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '1', '1', '1', '0', '0', '0', '1' }, new char[] { '0', '0', '0', '0', '1', '1', '1' }, new char[] { '0', '1', '1', '1', '0', '0', '0' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '1', '0', '0' }, new char[] { '0', '0', '0', '1' }, new char[] { '1', '0', '0', '0' } }, 1 },
        new object[] { new char[][] { new char[] { '1', '1', '1', '1', '1', '1', '0' }, new char[] { '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '1', '0', '1', '0', '0' }, new char[] { '1', '1', '1', '1', '0', '1', '1' }, new char[] { '1', '1', '1', '1', '1', '1', '1' }, new char[] { '1', '1', '0', '1', '1', '0', '1' } }, 9 },
        new object[] { new char[][] { new char[] { '1', '0', '0', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '0' }, new char[] { '0' }, new char[] { '1' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '0', '1', '0' }, new char[] { '1', '0', '0', '0' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '1' }, new char[] { '1', '0' }, new char[] { '1', '0' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '0', '0', '1', '0', '0' }, new char[] { '0', '1', '1', '1', '0', '1' }, new char[] { '0', '1', '1', '1', '1', '0' }, new char[] { '1', '1', '1', '1', '1', '1' } }, 9 },
        new object[] { new char[][] { new char[] { '1', '0', '0', '0', '0' }, new char[] { '0', '1', '0', '0', '0' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '1', '1', '1' }, new char[] { '0', '0', '1', '1' }, new char[] { '1', '0', '0', '0' }, new char[] { '1', '0', '0', '0' }, new char[] { '1', '0', '0', '1' }, new char[] { '0', '0', '1', '0' }, new char[] { '0', '1', '1', '0' } }, 4 },
        new object[] { new char[][] { new char[] { '0', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '0', '1', '0', '1' }, new char[] { '0', '1', '1', '0', '1' }, new char[] { '0', '1', '1', '0', '0' } }, 4 },
        new object[] { new char[][] { new char[] { '1', '1', '1', '1' } }, 1 },
        new object[] { new char[][] { new char[] { '0', '0', '0', '0', '0', '1' }, new char[] { '0', '1', '0', '0', '0', '1' }, new char[] { '1', '0', '1', '1', '0', '0' }, new char[] { '0', '1', '1', '1', '1', '1' }, new char[] { '0', '0', '1', '1', '1', '0' }, new char[] { '1', '1', '0', '0', '1', '0' }, new char[] { '0', '0', '0', '1', '0', '1' } }, 4 },
    };
}
