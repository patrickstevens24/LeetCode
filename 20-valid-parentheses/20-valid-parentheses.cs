public class Solution {
    public bool IsValid(string s) {
        Stack myStack = new Stack();
        Dictionary<char, char> closeToOpen = new Dictionary<char, char>() {
            {'}','{'},
            {']','['},
            {')','('}
        };
        if (s.Length % 2 != 1) {
            foreach(char c in s) {
                if (closeToOpen.ContainsKey(c)) {
                    if (myStack.Count > 0) {
                        if (Convert.ToChar(myStack.Peek()) == closeToOpen[c]) {
                            myStack.Pop();
                        } 
                        else 
                        {
                            return false;
                        }
                    }
                    else 
                    {
                        return false;
                    }
                } 
                else 
                {
                    myStack.Push(c);
                }
            }
        }
        else 
        {
            return false;
        }
        
        if (myStack.Count == 0) {
            return true;
        }
        else 
        {
            return false;
        }
    }
}