public class Solution {
    public int Trap(int[] height) {
        
        int left=0;
        int right=height.Length-1;
        int leftmax=0;
        int rightmax=0;
        int trappedWater=0;
        while(left<right)
        {
            if(height[left]<=height[right])
            {
                leftmax=Math.Max(leftmax, height[left]);
                trappedWater+=leftmax-height[left];
                left++;
            }
            else
            {
                rightmax=Math.Max(rightmax,height[right]);
                trappedWater+=rightmax-height[right];
                right--;
            }
        }
        return trappedWater;
    }
}
