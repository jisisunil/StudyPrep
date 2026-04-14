public class Solution {

    public List<List<int>> Subsets(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();

     //1,2,3

        Dfs1(nums, 0, new List<int>(), result);
        return result;
    }

    private void Dfs(int[] nums, int index, List<int> current, List<List<int>> result)
    {
        if (index >= nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        current.Add(nums[index]);
        Dfs(nums, index + 1, current, result);
        current.RemoveAt(current.Count - 1);
        Dfs(nums, index + 1, current, result);

    }

    private void Dfs1(int[] nums, int index, List<int> current, List<List<int>> result)
    {
       
            result.Add(new List<int>(current));
            
        for(int i=index;i<nums.Length;i++){
            current.Add(nums[i]);
            Dfs1(nums, i+1, current,result);
            current.RemoveAt(current.Count-1);
        }
        

    }
}
