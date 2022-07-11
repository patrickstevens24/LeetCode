function removeDuplicates(nums: number[]): number {
    
    for (let i = 0; i < nums.length; i++) {
        if (i < nums.length - 1) {
            if (nums[i] == nums[i + 1]) {
                nums.splice(i, 1);
                i--;
            }
        } 
    }
    return nums.length;
};