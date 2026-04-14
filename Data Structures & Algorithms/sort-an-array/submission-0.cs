public class Solution {
    public int[] SortArray(int[] nums) {
        
        int n = nums.Length;
        //Build maxheap
        for(int i= n/2-1;i>=0;i--)
        {
            Heapify(nums, n, i);
        }
        //Extract element one by one
        for(int i=n-1;i>=0;i--)
        {
            (nums[0],nums[i]) = (nums[i], nums[0]);
            Heapify(nums,i,0);
        }
        return nums;
    }


    private void Heapify(int[] nums, int heapsize, int i)
    {
        int largest =i;
        int left = 2*i+1;
        int right=2*i+2;

        if(left<heapsize && nums[left] > nums[largest])
        {
            largest=left;
        }

        if(right<heapsize && nums[right] > nums[largest])
        {
            largest = right;
        }

        if(largest!=i)
        {
            (nums[i],nums[largest])=(nums[largest], nums[i]);
            Heapify(nums, heapsize, largest);
        }
    }
}