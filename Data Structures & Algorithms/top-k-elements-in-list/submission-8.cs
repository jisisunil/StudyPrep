public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> freq = new Dictionary<int,int>();

        foreach(var num in nums)
        {
            if(!freq.ContainsKey(num))
            {
                freq[num]=0;
            }
            freq[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length+1];

        foreach(var pair in freq)
        {
            int value = pair.Key;
            int count = pair.Value;

            if(buckets[count]==null)
            {
                buckets[count] = new List<int>();
            }            
            buckets[count].Add(value);
        }

        int[] result = new int[k];
        int cnt=0;
        for(int i=buckets.Length-1; i>=0 &&cnt<k;i--)
        {
            if(buckets[i]==null) continue;
            foreach(var val in buckets[i])
            {
                result[cnt++]=val;
                if(cnt==k) break;
            }
        }
        return result;
    }
}
