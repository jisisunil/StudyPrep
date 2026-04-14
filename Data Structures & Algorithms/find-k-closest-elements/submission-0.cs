public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int n= arr.Length;

        int left=0;
        int right= n-k;//// starting index of window cannot go beyond this

        while(left<right)
        {
            int mid =left+(right-left)/2;

            int disleft= x-arr[mid];
            int disright=arr[mid+k]-x;

            if(disleft>disright)
            {
                left=mid+1;
            }
            else
            {
                right=mid;
            }
        }

        List<int> result=new List<int>(k);
        for(int i=left;i<left+k;i++)
        {
            result.Add(arr[i]);
        }
        return result;
    }
}