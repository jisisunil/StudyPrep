public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();
        List<int> currentSet = new List<int>();
        backtrack(nums, target, 0, currentSet, result);
        return result;
    }

    private void backtrack(int[] nums, int target, int index, List<int> currentSet, List<List<int>> result) {
        if (target < 0) return; // stop exploring this path if sum exceeds target

        if (target == 0) {
            result.Add(new List<int>(currentSet)); // found a valid combination
            return;
        }

        if (index >= nums.Length) return; // no more numbers to consider

        // Choose the current number (nums[index])
        // We stay at the same index because we can reuse the same number multiple times
        currentSet.Add(nums[index]);
        backtrack(nums, target - nums[index], index, currentSet, result);

        // Backtrack: remove the last added number and try the next one
        currentSet.RemoveAt(currentSet.Count - 1);

        // Move to the next index (try excluding current number)
        backtrack(nums, target, index + 1, currentSet, result);
    }
}
