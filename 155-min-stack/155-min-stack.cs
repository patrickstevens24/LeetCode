public class MinStack {

    Stack myStack = new Stack();
    Stack minStack = new Stack();
    public MinStack() {
        myStack = new Stack();
        minStack = new Stack();
    }
    
    public void Push(int val) {
        myStack.Push(val);
        if (minStack.Count > 0) {
            if (val < (int)minStack.Peek()) {
                minStack.Push(val);
            }
            else 
            {
                minStack.Push(minStack.Peek());
            }
        }
        else
        {
            minStack.Push(val);
        }
        
    }
    
    public void Pop() {
        myStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {       
        return (int)myStack.Peek();
    }
    
    public int GetMin() {
        return (int)minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */