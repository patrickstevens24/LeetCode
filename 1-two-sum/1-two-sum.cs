public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> numsDict = new(); 
        
        for(int a = 0; a < nums.Length; a++) {
            if (numsDict.TryGetValue(target - nums[a], out int b)){
                return new int[]{b,a};
            }
            numsDict[nums[a]] = a;
        }
        return null;
    }
}