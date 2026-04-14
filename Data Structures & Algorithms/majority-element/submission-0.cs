public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate=0;
        int count=0;

        for(int i=0;i<nums.Length;i++)
        {
            if(count==0)
            {
                candidate = nums[i];
                count++;
            }
            else if(candidate==nums[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return candidate;
    }
}