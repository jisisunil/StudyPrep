public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> result= new List<List<int>>();
        List<int> currentset = new List<int>();
        Array.Sort(candidates);
        Backtrack(candidates, target, 0, currentset, result, 0);
        return result;


    }

    private void Backtrack(int[] nums, int target, int index, List<int> currentset, List<List<int>> result, int total)
    {

        if(target==total)
        {
            result.Add(new List<int>(currentset));
            return;
        }
        if(index>=nums.Length || total >target)
        {
            return;
        }
        

        currentset.Add(nums[index]);
        Backtrack(nums, target, index+1, currentset, result, total+nums[index]);
        currentset.RemoveAt(currentset.Count-1);
        int next = index + 1;
        while (next < nums.Length && nums[next] == nums[index]) next++;
        Backtrack(nums, target, next, currentset, result, total);
    }
}
