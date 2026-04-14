public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        backtrack(nums, new List<int>(), new HashSet<int>(), result);
        return result;
        
    }


    private void backtrack(int[] nums, List<int> current, HashSet<int> used, List<List<int>> result)
    {
        if(current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i=0;i<nums.Length;i++)
        {
            if(used.Contains(nums[i])) continue;

            used.Add(nums[i]);
            current.Add(nums[i]);

            backtrack(nums, current, used, result);
            current.RemoveAt(current.Count-1);
            used.Remove(nums[i]);

        }
    }
}
