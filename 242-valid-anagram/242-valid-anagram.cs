public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length) {
            return false;
        }
        
        char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(t1);
        
        if (s1.SequenceEqual(t1)) {
            return true;
        } else {
            return false ;
        }
    }
}