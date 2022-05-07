public class Solution {
    public int HammingWeight(uint n) {
        int result = 0;
        while (n > 0) {
            result += n % 2 == 1 ? 1 : 0;
            n = n >> 1;
        }
        return result;
    }
}