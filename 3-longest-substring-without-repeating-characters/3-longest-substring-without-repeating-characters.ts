function lengthOfLongestSubstring(s: string): number {
    
    // map a character to its index in the array
    let map: Map<string, number> = new Map([]);
    let longest = 0; // longest substring found
    let length = 0; // length of the substring currently being calculated

    for(let i = 0; i < s.length; i++) {
        const encountered = map.get(s[i]);
        if (encountered === undefined) {
            length += 1;
        } else {
            length = Math.min(i - encountered, length + 1);
        }
        longest = Math.max(longest, length);
        map.set(s[i], i);
    }
    return longest;

};