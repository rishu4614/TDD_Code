using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack_Implementation
{
    public class MyStack<T>
    {
        private readonly List<T> list = new List<T>();
        public bool IsEmpty => Count == 0;
        public int Count => list.Count;

        public void Push(T value)
        {
            list.Add(value);
        }
        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            list.RemoveAt(Count - 1);
        }
        public T Peek()
        {
            return list[Count - 1];
        }
    }
}
