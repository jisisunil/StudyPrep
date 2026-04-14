public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {

        List<List<int>> result = new List<List<int>>();
        List<int> currentSet = new List<int>();
        backtrack(nums, target, 0, currentSet, result);
        return result;
    }


    private void backtrack(int[] nums, int target, int index, List<int> currentSet, List<List<int>> result)
    {
        if(target<0) return;

        if(target == 0)
        {
            result.Add(new List<int>(currentSet));
            return;
        }

        if(index>=nums.Length) return;

        currentSet.Add(nums[index]);
        backtrack(nums, target-nums[index], index, currentSet, result);
        currentSet.RemoveAt(currentSet.Count-1);
        backtrack(nums, target, index+1, currentSet, result);

    }
}
