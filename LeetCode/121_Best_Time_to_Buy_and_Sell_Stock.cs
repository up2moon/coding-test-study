public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int buy = prices[0];

        for (int i = 1; i < prices.Length; ++i)
        {
            int sell = prices[i];

            if (sell > buy)
                profit = Math.Max(profit, sell - buy);
            else
                buy = sell;
        }
        return profit;
    }
}