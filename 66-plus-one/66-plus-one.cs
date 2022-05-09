public class Solution {
    public int[] PlusOne(int[] digits) {
        
        Array.Reverse(digits);
        int remainder = 1;
        for(int i = 0; i < digits.Length; i++) {
            if ((digits[i] + remainder) == 10) {
                digits[i] = 0;
                remainder = 1;
            } else {
                digits[i] += remainder;
                remainder = 0;
            }
        }
        if (remainder > 0) {
            int[] increaseDigits = new int[(digits.Length + 1)];
            increaseDigits[0] = remainder;
            Array.Copy(digits, 0, increaseDigits, 1, digits.Length);    
            return increaseDigits;
        }
        Array.Reverse(digits);
        return digits;
    }
}