public class Solution {
    public void MoveZeroes(int[] nums) {
        int left=0;
        for(int right=0;right<nums.Length;right++)
        {
            if(nums[right]!=0)
            {
                nums[left]=nums[right];
                if(left!=right)
                  nums[right]=0;
                left++;
            }
        }

        
        
    }
}