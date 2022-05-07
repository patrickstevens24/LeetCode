public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> numsDict = new();
        foreach (int num in nums) {
            if (numsDict.ContainsKey(num)) {
                return true;
            }
            numsDict[num] = num;
        }
        return false;
    }
}