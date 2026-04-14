public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int,int> map = new Dictionary<int,int>();
        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]]=1;
            }
        }

        foreach(var entry in map)
        {
            minHeap.Enqueue(entry.Key, entry.Value);

            if(minHeap.Count >k)
            {
                minHeap.Dequeue();
            }

        }

        List<int> result = new List<int>();
        while(minHeap.Count>0)
       {
            result.Add(minHeap.Dequeue());
       }
        return result.ToArray();
       
    }
}
