public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] product = new int[nums.Length];
        int prefixProduct = 1;

        for(int i=0;i<nums.Length;i++)
        {
            product[i] = prefixProduct;
            prefixProduct *= nums[i];
        }

        int suffixProduct =1;

        for(int i=nums.Length-1;i>=0;i--)
        {
            product[i]*=suffixProduct;
            suffixProduct*=nums[i];
        }
        return product;
    }
}
