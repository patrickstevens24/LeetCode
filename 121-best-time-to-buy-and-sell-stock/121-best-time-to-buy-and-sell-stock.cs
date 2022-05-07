public class Solution {
   
    public int MaxProfit(int[] prices) {
        int result = 0;
        int min = -1;
        foreach (int price in prices) {
            if ((min == -1) || (price < min)) {
                min = price;
            } 
            else 
            {
                if ((price - min) > result) {
                     result = price - min;
                }
            }
        }
        return result;
    }
}