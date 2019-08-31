using System;
using System.Collections.Generic;

namespace Section4Inheritance
{
    namespace Exercises
    {
        // EXERCISE ONE
        public class Stack
        {

            public List<int> StackList { get; set; }

            public void Push(int number)
            {
                StackList.Add(number);
            }

            public int Pop()
            {
                if (StackList.Count == 0)
                    throw new InvalidOperationException("Stack is empty");

                var itemToRemove = StackList[StackList.Count - 1];

                StackList.RemoveAt(itemToRemove);

                return itemToRemove;
            }

            public void Clear()
            {
                StackList.Clear();
            }
        }
    }
}
