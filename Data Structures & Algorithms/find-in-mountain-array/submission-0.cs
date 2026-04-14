/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {

        int peak = FindPeak(mountainArr);    
        
        int index = BinarySearch(target, mountainArr, 0, peak, true);
        if(index!=-1) return index;
        return BinarySearch(target, mountainArr, peak+1, mountainArr.Length()-1,false);
    }
    private int FindPeak(MountainArray mountainArr)
    {

        int left=0;
        int right = mountainArr.Length()-1;
        while(left<right)
        {
            int mid = left+(right-left)/2;
            int midelt = mountainArr.Get(mid);
            int next=mountainArr.Get(mid+1);
            if(midelt<next)
            {
                left = mid+1;
            }
            else
            {
                right=mid;
            }
        }

        return left;

    }

    private int BinarySearch(int target, MountainArray mountainArr, int left, int right, bool asc)
    {
        int start = left;
        int end = right;
        
        while(start<=end)
        {
            int mid = start+(end-start)/2;
            int peak=mountainArr.Get(mid);
            if(target==peak)
            {
                return mid;
            }
            if(target<peak && asc)
            {
                end = mid-1;
            }
            else
            {
                start = mid+1;
            }
        }
        return -1;

    }

    
}