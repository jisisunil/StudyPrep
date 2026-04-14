public class Solution {
    public int MaxProfit(int[] prices) {
        
        if(prices == null || prices.Length<=1)
            return 0;

         int totalProfit=0;
         for(int i=1;i<prices.Length;i++)
         {

            if(prices[i] > prices[i-1])
            {
                totalProfit+=prices[i]-prices[i-1];
            }
         }
         return totalProfit;   
    }
}