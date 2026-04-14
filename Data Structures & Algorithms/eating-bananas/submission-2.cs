public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        int high = piles.Max();
        int low =1;
        int mid =0;
        while(low<high)
        {
            mid = low+(high-low)/2;

            bool canFinish = CanFinish(piles, h, mid);
            if(canFinish)
            {
                high=mid;
            }
            else
            {
                low = mid+1;
            }

        }
        return low;
    }

    private bool CanFinish(int[] piles, int h, int mid)
    {
        int totaltime =0;

        foreach(var pile in piles)
        {
            totaltime += (pile+mid-1)/mid;//totalTime += (int) Math.Ceiling((double) pile / speed);
            if(totaltime>h)
            {
                return false;
            }
        }
        return true;
    }
}
