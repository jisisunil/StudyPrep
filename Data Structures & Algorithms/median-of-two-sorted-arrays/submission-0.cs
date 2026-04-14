public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {

       if(nums1.Length > nums2.Length)
       {
          int[] temp = nums1;
          nums1=nums2;
          nums2= temp;
       }

       int m = nums1.Length;
       int n= nums2.Length;

       int low= 0;
       int high = m;

       while(low<=high)
       {

            int partitionx = (low+high)/2;
            int partitiony =(m+n+1)/2-partitionx;

            int maxleftx = (partitionx==0)?int.MinValue: nums1[partitionx-1];
            int minrightx= (partitionx==m)?int.MaxValue: nums1[partitionx];

            int maxlefty=(partitiony==0)?int.MinValue: nums2[partitiony-1];
            int minrighty=(partitiony==n)?int.MaxValue: nums2[partitiony];

            if(maxleftx<=minrighty && maxlefty<=minrightx)
            {
                if((m+n)%2==0)
                {
                    return (Math.Max(maxleftx,maxlefty)+
                    Math.Min(minrightx, minrighty))/2.0;
                }
                else
                {
                    return Math.Max(maxleftx,maxlefty);
                }
            }
            else if(maxleftx>minrighty)
            {
                high =  partitionx-1;
            }
            else
            {
                low= partitionx+1;
            }


       }

       throw new ArgumentException("Input arrays must be sorted.");

    }
}
