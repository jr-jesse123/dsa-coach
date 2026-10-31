namespace TopCoding.Array.Problems.P006_JumpGame;

public class Solution
{
    public bool CanJump(int[] nums)
    {


        //fronteira é até onde ocnseguimos chegar até agora.
        int fronteira = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (i > fronteira) return false;

            fronteira = Math.Max(fronteira, i + nums[i]);

        }

        return true;

    }


}
