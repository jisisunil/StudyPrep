public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        

        int low = 1;

        int max = piles.Max();
        int mid=0;
        while(low<max)
        {
            mid= low+(max-low)/2;

            bool canFinish= canDo(piles, h, mid);
            if(canFinish)
            {
                max=mid;
            }
            else
            {
                low=mid+1;
            }
        }
        return low;
    }


    private bool canDo(int[] piles, int h, int mid)
    {
        int totaltime=0;
        foreach(var pile in piles)
        {
            totaltime+=(pile+mid-1)/mid;
            if(totaltime>h) return false;
           
        }
        
        return true;
    }
}
