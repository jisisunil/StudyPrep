public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left=0;
        int right = arr.Length-1;

        while(right-left+1 > k)
        {
            if(Math.Abs(arr[left]-x)> Math.Abs(arr[right]-x))
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        List<int> result = new List<int>();
        for(int i=left;i<=right;i++)
        {
            result.Add(arr[i]);
        }
        return result;
    }
}