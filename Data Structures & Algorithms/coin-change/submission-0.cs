public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp= new int[amount+1];
        for(int i=1;i<dp.Length;i++)
        {
            dp[i]= amount+1;
        }

        dp[0] =0;//To make amount 0, the minimum number of coins required is 0 coins.

        for(int i=1;i<=amount;i++)
        {
            foreach(var coin in coins)
            {
                if(coin<=i)
                {
                    dp[i]=Math.Min(dp[i],dp[i-coin]+1);
                }
            }
        }
        return dp[amount]>amount ?-1: dp[amount];
    }
}
