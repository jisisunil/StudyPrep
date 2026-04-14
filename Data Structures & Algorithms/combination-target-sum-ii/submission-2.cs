public class Solution {
    public List<List<int>> CombinationSum2(int[] nums, int target) {
        Array.Sort(nums); // sort to handle duplicates
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

        if (target < 0) return;

        for (int i = index; i < nums.Length; i++) {
            // Skip duplicates at the same recursion level
            if (i > index && nums[i] == nums[i - 1])
                continue;

            int val = nums[i];
            if (val > target) break; // no point continuing because sorted

            // choose nums[i]
            currentSet.Add(val);
            backtrack(nums, target - val, i + 1, currentSet, result); 
            currentSet.RemoveAt(currentSet.Count - 1);
        }
    }
}
