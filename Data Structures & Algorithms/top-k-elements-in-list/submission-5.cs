public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> map = new Dictionary<int,int>();

        foreach(int num in nums)
        {
          if(!map.ContainsKey(num))
          {
            map[num]=0;
          }
          map[num]++;
        }
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();

        foreach(var entry in map)
        {
          pq.Enqueue(entry.Key,entry.Value);
          if(pq.Count>k)
          {
            pq.Dequeue();
          }
        }

        int[] arr = new int[k];

        for(int i=0;i<k;i++)
        {
          arr[i] =pq.Dequeue();
        }
        return arr;
    }
}
