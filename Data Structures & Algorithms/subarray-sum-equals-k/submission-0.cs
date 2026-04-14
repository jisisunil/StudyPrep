public class Solution {
    public int SubarraySum(int[] nums, int k) {
        
        Dictionary<int,int> map= new Dictionary<int,int>();
        map[0]=1;
        int prefixSum=0;
        int count=0;
        for(int i=0;i<nums.Length;i++)
        {
            prefixSum+=nums[i];

            if(map.ContainsKey(prefixSum-k))
            {
                count+=map[prefixSum-k];
            }

            if(map.ContainsKey(prefixSum))
            {
                map[prefixSum]++;
            }
            else
            {
                map[prefixSum]=1;
            }
        }
        return count;
    }
}