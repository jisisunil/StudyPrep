public class Solution {
    public List<int> MajorityElement(int[] nums) {

        int count1=0;
        int count2=0;
        int candidate1=0;
        int candidate2=0;

        int n=nums.Length;

        foreach(int num in nums)
        {
            if(num== candidate1)
            {                
                count1++;
            }
            else if(num==candidate2)
            {                
                count2++;
            }
            else if(count1==0)
            {
                candidate1=num;
                count1++;
            }
            else if(count2==0)
            {
                candidate2=num;
                count2++;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        List<int> result = new List<int>();
        count1=0;
        count2=0;
        foreach(var num in nums)
        {
            if(num == candidate1)
            {
                count1++;
            }
            else if(num == candidate2)
            {
                count2++;
            }
        }

        if(count1>n/3)
        {
            result.Add(candidate1);
        }
        if(count2>n/3)
        {
            result.Add(candidate2);
        }

        return result;
        
    }
}