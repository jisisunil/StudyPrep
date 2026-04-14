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
        
        //include 
        currentset.Add(nums[index]);
        Backtrack(nums, target, index+1, currentset, result, total+nums[index]);//here we cannot pass index as we cannot reuse same elements as we should not use duplicate
        currentset.RemoveAt(currentset.Count-1);
        
        while (index+1 < nums.Length && nums[ index + 1] == nums[index]) index++;
        Backtrack(nums, target, index+1, currentset, result, total);
    }
}
