public class Solution {
    public List<List<int>> Subsets(int[] nums) {
       List<List<int>> result = new List<List<int>>();
       List<int> currentSubset = new List<int>();
       GenerateSubSets(nums, 0, currentSubset, result);
        return result;
    }

    private void GenerateSubSets(int[] nums, int index, List<int> currentSubset, List<List<int>> result)
    {
        if(index>= nums.Length)
        {
            result.Add(new List<int>(currentSubset));
            return;
        }

        currentSubset.Add(nums[index]);
        GenerateSubSets(nums, index+1, currentSubset, result);
        currentSubset.RemoveAt(currentSubset.Count-1);
        GenerateSubSets(nums, index+1, currentSubset, result);
    }
}
