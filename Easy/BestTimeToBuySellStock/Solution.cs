public class Solution
{
    public int MaxProfit(int[] nums)
    {
        int minValue = int.MaxValue;
        int profit = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < minValue)
            {
                minValue = nums[i];
            }
            else if ((nums[i] - minValue) > profit) { 
                profit = nums[i]-minValue;
            }
        } 
        return profit;
    }
}