public class MinStack {
    Stack<int> stk;
    Stack<int> minStk;
    public MinStack() {
        stk = new Stack<int>();
        minStk = new Stack<int>();
    }
    
    public void Push(int val) {
        stk.Push(val);
        if(minStk.Count ==0 || minStk.Peek()>=val){
            minStk.Push(val);
        }
    }
    
    public void Pop() {

        if(minStk.Peek() ==stk.Pop()){
            minStk.Pop();
        }
    }
    
    public int Top() {
        return stk.Peek();
    }
    
    public int GetMin() {
        return minStk.Peek();
    }
}
