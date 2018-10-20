﻿using System;

namespace Stack
{
    /// <summary>
    /// Represents a variable size last-in-first-out (LIFO)
    /// collection of instances of the same specified type.
    /// </summary>
    /// <typeparam name="T">Generic data type</typeparam>
    class MyStack <T>
    {
        private int maxSize;
        private int actualSize;
        private T[] StackArr;

        /// <summary>
        /// Initializes a new instance of the MyStack class that is empty
        /// </summary>
        public MyStack()
        {
            actualSize = 0 ;
            maxSize = 0 ;
        }

        /// <summary>
        /// Initializes a new instance of MyStack with the specified initial capacity.
        /// </summary>
        /// <param name="initialCapacity"></param>
        public MyStack(int initialCapacity)
        {
            StackArr = new T[initialCapacity];
            actualSize = initialCapacity;
            maxSize = initialCapacity;
        }
        
        /// <summary>
        /// Resizes stack to new capacity  
        /// </summary>
        /// <param name="newCapacity">Value of new capacity </param>
        public void Resize(int newCapacity)
        {            
            Array.Resize(ref StackArr, newCapacity);
            actualSize = newCapacity;
            if (newCapacity > maxSize) maxSize = newCapacity;             
        }
        
        /// <summary>
        /// Inserts an object at the top of the stack.
        /// </summary>
        /// <param name="newValue">The value of the new element for add</param>
        void Push(T newValue)
        {
            if (maxSize == actualSize)
            {
                Array.Resize(ref StackArr, StackArr.Length + 1);
                StackArr[StackArr.Length + 1] = newValue;
                actualSize = StackArr.Length + 1;
                maxSize = StackArr.Length + 1;                
                System.Console.Write("stack size was increased");
            }
            else
            {
                StackArr[actualSize + 1] = newValue;
                actualSize++;
            }
        }

        /// <summary>
        /// Returns the object at the top of the stack without removing it.
        /// </summary>
        /// <returns>
        /// Returns the object at the top of the stack
        /// or null if stack is empty
        /// </returns>
        public T GetHead()
        {
            if(StackArr != null)
            {
                return StackArr[StackArr.Length-1];
            }

            return default(T);                
        }

        /// <summary>
        /// Removes and returns the object at the top of the stack.
        /// </summary>
        /// <returns>The object at the top of the stack or null if stack is empty.</returns>  
        public T Pop()
        {
            if (actualSize > 0)
            {
                T returnableElement = StackArr[actualSize - 1];
                StackArr[actualSize - 1] = default(T);
                System.Console.Write(returnableElement);
                return returnableElement;
            }
            else
            {
                System.Console.Write("Stack is empty");
                return default(T);
            }
        }
    }
}