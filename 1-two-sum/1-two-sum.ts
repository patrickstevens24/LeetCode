function twoSum(nums: number[], target: number): number[] {
    
    //Storing the value and the index 
    const numsMap = new Map<number, number>();
    
    let returnNums: number[] = [];
    
    for (let i = 0; i < nums.length; i++) {
        const targetIndex = numsMap.get(target - nums[i]);
        
        if (targetIndex !== undefined) {
            returnNums = [targetIndex, i];
            break;
        }
        
        numsMap.set(nums[i], i);
    }
    
    return returnNums;

};