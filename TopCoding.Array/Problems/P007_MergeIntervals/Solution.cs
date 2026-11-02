namespace TopCoding.Array.Problems.P007_MergeIntervals;

using System;

public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        var sortedIntevals = intervals.OrderBy(i => i[0]);

        List<List<int>> output = [];

        output.Add(sortedIntevals.First().ToList());

        foreach (var intv in sortedIntevals.Skip(1))
        {
            var currentEnd = output.Last()[1];

            if (intv[0] <= currentEnd)
            {
                output[output.Count - 1] = [output.Last()[0], Math.Max(intv[1], currentEnd) ];
            }
            else
            {
                output.Add(intv.ToList());
            }
        }


        return output.Select(x => x.ToArray()).ToArray();
    }
}
