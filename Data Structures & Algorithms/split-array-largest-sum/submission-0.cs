public class Solution {
    public int SplitArray(int[] nums, int k) {
        int low = nums.Max();

        int high=nums.Sum();

        while(low<high)
        {
            int mid = low+(high-low)/2;
            if(canSplit(nums, k, mid))
            {
                high=mid;
            }
            else
            {
                low=mid+1;
            }
        }
        return low;
    }



    private bool canSplit(int[]nums, int k, int mid)
    {
        int largestSum=0;
        int count=1;

        foreach(var num in nums)
        {
            if(largestSum+num>mid)
            {
                count++;
                largestSum=num;

                if(count>k)
                {
                    return false;
                }

            }
            else
            {
                largestSum+=num;
            }
        }
        return true;
    }
}