public class Solution {
    public int MaxProduct(int[] nums) {
        
        int max=nums[0];
        int min = nums[0];
        int result=nums[0];

        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]<0)
            {
                int temp=max;
                max =min;
                min=temp;
            }

            max = Math.Max(nums[i], nums[i]*max);
            min=Math.Min(nums[i], nums[i]*min);
            result = Math.Max(result,max);
        }
        return result;
    }
}
