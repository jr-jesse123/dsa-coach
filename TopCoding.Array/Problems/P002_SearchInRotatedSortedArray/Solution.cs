namespace TopCoding.Array.Problems.P002_SearchInRotatedSortedArray;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        var input = nums.Aggregate("", (a, b) => a.ToString() + b.ToString());
        Console.WriteLine(input);


        (int leftIdx, int rightIdx) = (0, nums.Length - 1);
        
        while(leftIdx <= rightIdx){

            int midIdx = ((rightIdx - leftIdx) / 2) + leftIdx;

            if (nums[midIdx] == target) return midIdx;

            if (nums[leftIdx] <= nums[midIdx])
            {
                if (nums[leftIdx] <= target && target < nums[midIdx] )
                {
                    rightIdx = midIdx - 1;
                }
                else
                {
                    leftIdx = midIdx + 1;
                }
            }
            else
            {
                if (nums[midIdx] < target && target <= nums[rightIdx] )
                {
                    leftIdx = midIdx + 1;
                }
                else
                {
                    rightIdx = midIdx - 1;
                }
            }
        }

        return -1;
    }
}
