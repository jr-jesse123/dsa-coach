namespace TopCoding.Array.TestData;

public static class P033Data
{
    public static IEnumerable<object[]> Cases => new List<object[]>
    {
        new object[] { new int[] { 1000, 100, 10, 2 }, "1000/(100/10/2)" },
        new object[] { new int[] { 2, 3, 4 }, "2/(3/4)" },
        new object[] { new int[] { 2 }, "2" },
        new object[] { new int[] { 1000 }, "1000" },
        new object[] { new int[] { 2, 3 }, "2/3" },
        new object[] { new int[] { 5, 2 }, "5/2" },
        new object[] { new int[] { 2, 2, 2 }, "2/(2/2)" },
        new object[] { new int[] { 3, 2, 5, 7, 11 }, "3/(2/5/7/11)" },
        new object[] { new int[] { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 }, "1000/(1000/1000/1000/1000/1000/1000/1000/1000/1000)" },
        new object[] { new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, "2/(2/2/2/2/2/2/2/2/2)" },
        new object[] { new int[] { 2, 1000, 2, 1000, 2, 1000, 2, 1000, 2, 1000 }, "2/(1000/2/1000/2/1000/2/1000/2/1000)" },
        new object[] { new int[] { 15, 17, 9, 8 }, "15/(17/9/8)" },
        new object[] { new int[] { 27 }, "27" },
        new object[] { new int[] { 28, 8, 8 }, "28/(8/8)" },
        new object[] { new int[] { 13, 29 }, "13/29" },
        new object[] { new int[] { 4 }, "4" },
        new object[] { new int[] { 22, 29, 15 }, "22/(29/15)" },
        new object[] { new int[] { 20, 27, 16 }, "20/(27/16)" },
        new object[] { new int[] { 18, 21, 17, 29, 17 }, "18/(21/17/29/17)" },
        new object[] { new int[] { 26, 4, 22, 7, 12 }, "26/(4/22/7/12)" },
        new object[] { new int[] { 7, 25, 25 }, "7/(25/25)" },
        new object[] { new int[] { 17, 3, 29, 26, 9, 20, 28 }, "17/(3/29/26/9/20/28)" },
        new object[] { new int[] { 18 }, "18" },
        new object[] { new int[] { 20, 25 }, "20/25" },
        new object[] { new int[] { 22, 8, 22 }, "22/(8/22)" },
        new object[] { new int[] { 8, 16 }, "8/16" },
        new object[] { new int[] { 22, 4, 4, 28, 21, 21, 6 }, "22/(4/4/28/21/21/6)" },
        new object[] { new int[] { 12, 21, 20, 29 }, "12/(21/20/29)" },
        new object[] { new int[] { 15, 8, 27, 11 }, "15/(8/27/11)" },
        new object[] { new int[] { 3, 25, 14, 21, 5, 21, 5 }, "3/(25/14/21/5/21/5)" },
        new object[] { new int[] { 4, 5, 11 }, "4/(5/11)" },
    };
}
