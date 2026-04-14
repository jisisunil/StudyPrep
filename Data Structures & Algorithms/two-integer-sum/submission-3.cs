public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int[] result = new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            if(map.ContainsKey(target-nums[i]))
            {
                result[0] = map[target-nums[i]];
                result[1] =i;
                return result;
            }
            else
            {
                map[nums[i]] = i;
            }
        }
        return result;
    }
}
