public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] product = new int[nums.Length];
        int prefix =1;

        for(int i=0;i<nums.Length;i++)
        {
            product[i] =prefix;
            prefix*=nums[i];
        }

        int suffix=1;

        for(int i=nums.Length-1;i>=0;i--)
        {
            product[i]*=suffix;
            suffix*=nums[i];
        }
        return product;
    }
}
