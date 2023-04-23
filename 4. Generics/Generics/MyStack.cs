using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyStack<T>
    {
        private readonly Stack<T> _stack = new Stack<T>();

        int Count()
        {
            return _stack.Count;
        }

        T Pop()
        {
            return _stack.Pop();
        }

        void Push(T item)
        {
            _stack.Push(item);
        }
    }
}
