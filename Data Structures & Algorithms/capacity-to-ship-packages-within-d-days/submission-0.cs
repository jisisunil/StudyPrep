public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int min =weights.Max();

        int max=weights.Sum();
        int mid=0;
        while(min<max)
        {

            mid = min+(max-min)/2;

            bool ship = canShip(weights, days, mid);
            if(ship)
            {
                max=mid;
            }
            else
            {
                min=mid+1;
            }
        }

        return min;

    }

    private bool canShip(int[] weights, int days, int mid)
    {
        int totalweight=0;
        int daysRequired=1;
        foreach(var weight in weights)
        {
            if(totalweight+weight > mid)
            {
                daysRequired++;
                totalweight=weight;
                if(daysRequired>days)
                {
                    return false;
                }
            }
            else
            {
                totalweight+=weight;
            }

        }
        return true;
    }
}