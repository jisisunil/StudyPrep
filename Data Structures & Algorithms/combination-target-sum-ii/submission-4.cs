public class Solution {
    public List<List<int>> CombinationSum2(int[] nums, int target) {
        Array.Sort(nums); // required for duplicate skipping
        List<List<int>> result = new List<List<int>>();
        List<int> currentSet = new List<int>();
        backtrack(nums, target, 0, currentSet, result);
        return result;
    }

    private void backtrack(int[] nums, int target, int index, List<int> currentSet, List<List<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(currentSet));
            return;
        }

        if (target < 0 || index >= nums.Length) return;

        // INCLUDE nums[index]
        currentSet.Add(nums[index]);
        backtrack(nums, target - nums[index], index + 1, currentSet, result);
        currentSet.RemoveAt(currentSet.Count - 1);

        // EXCLUDE nums[index]
        // But skip ALL duplicates of nums[index]
        //int nextIndex = index + 1;
        while (index + 1 < nums.Length && nums[index + 1] == nums[index]) {
            index++;
        }

        backtrack(nums, target, index + 1, currentSet, result);
    }
}
