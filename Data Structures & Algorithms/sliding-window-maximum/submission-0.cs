public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        LinkedList<int> dequeue = new LinkedList<int>();

        int left =0;
        int right=0;
        int n = nums.Length;
        int[] result = new int[n-k+1];
        while(right<n)
        {

            while(dequeue.Count >0 && nums[dequeue.Last.Value] < nums[right])
            {
                dequeue.RemoveLast();
            }
            dequeue.AddLast(right);
            if(left>dequeue.First.Value)
            {
                dequeue.RemoveFirst();
            }
            if(right+1>=k)
            {
                result[left] = nums[dequeue.First.Value];
                left++;
            }
            right++;
        }
        return result;
    }
}
