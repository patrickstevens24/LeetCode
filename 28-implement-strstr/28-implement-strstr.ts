function strStr(haystack: string, needle: string): number {
    for (let i = 0; i <= haystack.length - needle.length; ++i) {
    if (haystack.startsWith(needle, i)) {
      return i;
    }
  }

  return -1;

};