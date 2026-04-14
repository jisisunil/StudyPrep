public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        
        Array.Sort(nums);
        return NSum(nums, target, 4);

    }


    private List<List<int>> NSum(int[] nums, int target, int n)
    {
        List<List<int>> result = new List<List<int>>();

        List<int> current = new List<int>();

        NSumHelper(nums, target, n, 0, current, result);
        return result;
    }


    private void NSumHelper(int[]nums, int target, int n, int start, List<int> current, List<List<int>> result)
    {
        if(n<2 || nums.Length<n)
        {
            return;
        }
          // ---- Pruning using min / max possible sum ----
        long min = (long)nums[start] * n;          // smallest possible sum
        long max = (long)nums[nums.Length - 1] * n; // largest possible sum

        if (target < min || target > max)
            return;
        if(n==2)//base case
        {
            int left=start;
            int right =nums.Length-1;

            while(left<right)
            {
                long sum = (long)nums[left] + nums[right];
                if(sum==target)
                {
                    result.Add(new List<int>(current){nums[left], nums[right]});
                    left++;
                    right--;

                    while(left<right && nums[left]==nums[left-1])
                    {
                        left++;
                    }
                    while(left<right && nums[right]==nums[right+1])
                    {
                        right--;
                    }
                }
                else if(sum<target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return;            
        }
        for(int i=start;i<nums.Length-n+1;i++)
        {
            if(i>start && nums[i]==nums[i-1])
            {
                continue;
            }

            current.Add(nums[i]);
            NSumHelper(nums, target-nums[i],n-1, i+1, current, result);
            current.RemoveAt(current.Count-1);
        }

    }
}