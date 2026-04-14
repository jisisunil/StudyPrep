public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
     List<List<int>> result = new List<List<int>>();
    
     HashSet<int> used = new HashSet<int>();
     int [] res = new int[nums.Length];
     dfs(nums, used, result,res,0);

     return result;

    }


    private void dfs(int[] nums, HashSet<int> used, List<List<int>> result, int[] res, int level)
    {

        if(level== nums.Length)
        {
            result.Add(res.ToList());
            return;
        }


        for(int i=0;i<nums.Length;i++)
        {
            if(used.Contains(nums[i]))
                continue;

            res[level] = nums[i];
            used.Add(nums[i]);
            dfs(nums, used, result, res, level+1);
            used.Remove(nums[i]);
        }
        
    }
}
