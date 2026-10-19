namespace TopCoding.Array.Problems.P001_ContainerWithMostWater;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int leftIdx = 0;
        int rightIdx = height.Length - 1;


        while(leftIdx < rightIdx)
        {
            var leftHeight = height[leftIdx];
            var rightHeight = height[rightIdx];

            maxArea = Math.Max(maxArea, (rightIdx - leftIdx) * Math.Min(leftHeight, rightHeight));


            if(leftHeight < rightHeight) leftIdx++;
            if (leftHeight > rightHeight) rightIdx--;
            if (leftHeight == rightHeight) leftIdx++;
        }

        return maxArea;
    }
}
