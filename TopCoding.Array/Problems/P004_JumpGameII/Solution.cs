namespace TopCoding.Array.Problems.P004_JumpGameII;

public class Solution
{
    public int Jump(int[] nums)
    {
        int currIdx = 0;
        int jumps = 0;

        while(currIdx < nums.Length - 1)
        {
            var maxTarget = Math.Min(currIdx + nums[currIdx], nums.Length -1) ;

            var options =
                nums[(currIdx + 1)..(maxTarget + 1)]
                .Select((v, idx) => new { weight = (v + idx), idx })
                //.OrderByDescending(opt => opt.idx)
                ;

            var bestOptIdx = options.MaxBy(o => o.idx + currIdx + 1 == nums.Length - 1 ? int.MaxValue: o.weight)!.idx + 1;


            
            

            currIdx = currIdx + bestOptIdx;

            jumps++;

        }

        return jumps;
    }
}
