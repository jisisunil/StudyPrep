public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        List<List<int>> result = new List<List<int>>();

        List<int> current = new List<int>();
        bool[] used=new bool[nums.Length];
        PermuteHelper(nums,used, current, result);
        return result;
    }

    private void PermuteHelper(int[] nums,bool[] used, List<int> current, List<List<int>> result)
    {
        if(current.Count == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for(int i=0;i<nums.Length;i++)
        {
            if(used[i]) continue;

            
            current.Add(nums[i]);
            used[i]=true;
            PermuteHelper(nums, used, current, result);
            current.RemoveAt(current.Count-1);
            used[i]=false;
        }
    }
}
