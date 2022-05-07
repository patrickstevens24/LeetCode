public class Solution {
    public int LengthOfLongestSubstring(string s) {
        StringBuilder returnString = new StringBuilder();
        int returnVal = 0;
        foreach (char c in s) {
            if (!returnString.ToString().ToString().Contains(c)) {
                returnString.Append(c);
                if (returnString.ToString().Length > returnVal) {
                     returnVal = returnString.ToString().Length;
                }
            } 
            else 
            {
                if (returnString.ToString().Length > returnVal) {
                     returnVal = returnString.ToString().Length;
                }
                
                while (returnString.Length >= 0 && returnString.ToString().ToString().Contains(c)) {
                    returnString = returnString.Remove(0, 1);
                }
                returnString.Append(c);
            }
        }
        return returnVal;
    }
}