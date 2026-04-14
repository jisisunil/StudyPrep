public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {

        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        Array.Sort(nums);
        backtrack(nums, 0, current,result);
        return result;
    }


    private void backtrack(int[] nums, int index, List<int> currentSet, List<List<int>> result)
    {
        if(index ==nums.Length)
        {
            result.Add(new List<int>(currentSet));
            return;
        }

        currentSet.Add(nums[index]);
        backtrack(nums, index+1, currentSet, result);
        currentSet.RemoveAt(currentSet.Count-1);
        int next = index+1;
        while(next<nums.Length && nums[next]==nums[index]) 
        {
            next++;
        }
        backtrack(nums, next, currentSet, result);
    }
}
