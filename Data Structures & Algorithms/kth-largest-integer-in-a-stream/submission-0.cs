public class KthLargest {
    PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
    int cnt =0;
    public KthLargest(int k, int[] nums) {
        
        cnt=k;
        for(int i=0;i<nums.Length;i++)
        {
            minHeap.Enqueue(nums[i],nums[i]);
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val,val);
        while(minHeap.Count > cnt)
        {
            minHeap.Dequeue();
        }
        return minHeap.Peek();
    }
}
