public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        int startindex=0;
        int tank=0;// think like live fuel gauge-how much gas currently you ahve
        int total=0;//like a trip notebook-the overall balance of gas vs cost over the entire route
        for(int i=0;i<gas.Length;i++)
        {
            int diff = gas[i] - cost[i];
            total+=diff;
            tank+=diff;
            if(tank<0)
            {
                startindex=i+1;
                tank=0;

            }
        }
        return total<0?-1:startindex;
    }
}
