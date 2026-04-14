public class Solution {
    public void SortColors(int[] nums) {

        int low =0;int mid=0; int high= nums.Length-1;

        while(mid<=high)
        {
            switch(nums[mid])
            {
                case 0:
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++;
                    mid++;
                    break;
                }
                case 1:
                {
                    mid++;
                    break;
                }
                case 2:
                {
                    int temp= nums[high];
                    nums[high]=nums[mid];
                    nums[mid]=temp;
                    high--;
                    break;
                }
            } 
        }
        
    }
}