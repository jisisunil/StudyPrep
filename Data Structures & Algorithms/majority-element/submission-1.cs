public class Solution {
    public int MajorityElement(int[] nums) {

        int candidate=0;
        int count=0;

        foreach(var num in nums)
        {
            if(num==candidate)
            {
                count++;
            }
            else if(count==0)
            {
                candidate= num;
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