using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class MinStack
    {
        // LeetCode #155. Min Stack
        Stack<int> stack = new Stack<int>();
        Stack<int> min = new Stack<int>();

        public MinStack() { }

        public void Push(int x)
        {
            if (min.Count == 0 || x < min.Peek())
            {
                min.Push(x);
            }
            stack.Push(x);
        }

        public void Pop()
        {
            if (stack.Peek() == min.Peek())
            {
                min.Pop();
            }
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return min.Peek();
        }
    }
}
