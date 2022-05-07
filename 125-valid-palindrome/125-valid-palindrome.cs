public class Solution {
    public bool IsPalindrome(string s) {
        
        StringBuilder check = new StringBuilder();
        
        foreach (char l in s) {
            if (Char.IsLetterOrDigit(l) && l != ' ') {
                check.Append(Char.ToLower(l));
            }
        }
        if (check.ToString() == new string(check.ToString().Reverse().ToArray())) {
            return true;
        }
        return false;
        
    }
}