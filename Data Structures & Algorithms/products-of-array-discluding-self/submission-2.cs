public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int n=  nums.Length-1;
        int[] product = new int[n+1];
        
        int prefix=1;

        for(int i=0;i<n+1;i++)
        {
            product[i] = prefix;
            prefix*=nums[i];

            Console.WriteLine(product[i]);
        }
        
        int suffix=1;

        for(int i= n;i >=0;i--)
        {
            product[i]*=suffix;
            suffix*=nums[i];
        }

        return product;

    }
}


//Feedback: do not confuse with array length and while assigning the length;