public class Solution
{
    public List<List<int>> FourSum(int[] nums, int target)
    {
        Array.Sort(nums);
        // pass target as long to avoid overflow in recursion
        return NSum(nums, (long)target, 4);
    }

    public List<List<int>> NSum(int[] nums, long target, int n)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();

        NSumHelper(nums, target, n, 0, current, result);
        return result;
    }

    private void NSumHelper(int[] nums, long target, int n, int start,
                            List<int> current, List<List<int>> result)
    {
        // Use remaining length, not total length
        if (n < 2 || nums.Length - start < n)
        {
            return;
        }

        long min = (long)nums[start] * n;                 // smallest possible sum
        long max = (long)nums[nums.Length - 1] * n;       // largest possible sum

        if (target < min || target > max)
            return;

        if (n == 2)
        {
            int left = start;
            int right = nums.Length - 1;

            while (left < right)
            {
                long sum = (long)nums[left] + nums[right];

                if (sum == target)
                {
                    result.Add(new List<int>(current) { nums[left], nums[right] });
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
                else if (sum < target)
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

        for (int i = start; i < nums.Length - n + 1; i++)
        {
            if (i > start && nums[i] == nums[i - 1]) continue;

            current.Add(nums[i]);
            // target is long, nums[i] is int → stays in long safely
            NSumHelper(nums, target - nums[i], n - 1, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
