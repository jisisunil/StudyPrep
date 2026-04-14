public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();

        List<int> current = new List<int>();

        dfs(nums, target, 0, current, result);
        return result;
    }


    public void dfs(int[] nums, int target, int index, List<int> current, List<List<int>> result)
    {
        if(target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }
        if(index>=nums.Length || target<0) return;
        current.Add(nums[index]);

        dfs(nums, target-nums[index], index, current,result);

        current.RemoveAt(current.Count-1);

        dfs(nums, target, index+1, current, result);

    }
}
