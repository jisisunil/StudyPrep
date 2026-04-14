public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result= new List<List<int>>();
        if(nums.Length==3)
        {
            if(nums[0]+nums[1]+nums[2]==0)
            {
                result.Add(new List<int>{nums[0],nums[1],nums[2]});
                return result;
            }

        }
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++)
        {

            if(i>0 && nums[i]==nums[i-1])
            {
                continue;
            }
            int left=i+1;
            int right=nums.Length-1;

            while(left<right)
            {
                int sum=nums[i]+nums[left]+nums[right];
                if(sum==0)
                {
                    result.Add(new List<int>{nums[i],nums[left],nums[right]});
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
                else if(sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;

    }
}
