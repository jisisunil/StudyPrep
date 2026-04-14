public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        int[] res = new int[nums.Length];
        //int[] numsCount = new int[nums.Length]; // marks used elements
        
        //for (int i = 0; i < nums.Length; i++)
            //numsCount[i] = 1; // all elements available at start
        HashSet<int> used = new HashSet<int>();
        PermuteHelper(nums, used, result, res, 0);
        return result;
    }

    public static void PermuteHelper(int[] nums, HashSet<int> used,
                                     List<List<int>> result, int[] res, int level)
    {
        if (level == nums.Length)
        {
            result.Add(res.ToList());
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used.Contains(nums[i]))
                continue;

            res[level] = nums[i];   // choose nums[i] for this position
            used.Add(nums[i]);         // mark as used
            PermuteHelper(nums, used, result, res, level + 1); // go deeper
            used.Remove(nums[i]);         // unmark (backtrack)
        }
    }
}