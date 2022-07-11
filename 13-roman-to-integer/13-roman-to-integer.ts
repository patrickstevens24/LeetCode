function romanToInt(s: string): number {
    
    let returnNumber = 0;
    const romanMap = new Map<string, number>([
        ["I", 1],
        ["V", 5],
        ["X", 10],
        ["L", 50],
        ["C", 100],
        ["D", 500],
        ["M", 1000]
    ]);
    
    
    for (let i = 0; i < s.length; i++) {
        const currNumber = romanMap.get(s[i]);
        
        if (i < s.length - 1) {
          if (currNumber === 1 || currNumber === 10 || currNumber === 100) {
              
            const nextNumber = romanMap.get(s[i + 1])!;

            if (nextNumber > currNumber) {
              returnNumber += nextNumber - currNumber;
              i++;
              continue;
            }
          }
        }

        returnNumber += currNumber;
    }
    
    return returnNumber;
    

};

