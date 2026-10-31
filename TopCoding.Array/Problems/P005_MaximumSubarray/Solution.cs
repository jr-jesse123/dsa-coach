namespace TopCoding.Array.Problems.P005_MaximumSubarray;

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int max = int.MinValue;

        
        int currTotal = int.MinValue;
        int MaxTotal = int.MinValue;

        for(int i = 0; i < nums.Length; i++)
        {
          
            if(currTotal < 0)
            {
                currTotal = 0; //recomeça
            }

            currTotal += nums[i];

            MaxTotal = Math.Max(MaxTotal, currTotal);
        }


        return MaxTotal;

    }
}
