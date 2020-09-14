using System.Collections.Generic;

namespace LeetCode.Algorithms
{
    public class MinStack
    {
        /* LeetCode #155. Min Stack
         * Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
         * push(x) -- Push element x onto stack.
         * pop() -- Removes the element on top of the stack.
         * top() -- Get the top element.
         * getMin() -- Retrieve the minimum element in the stack.*/
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
