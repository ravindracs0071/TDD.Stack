﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDD.Stack.WebApp.Models
{
    public class Stack<T>
    {
        #region 
        private T[] stackArray;
        private int maximumLength;
        #endregion

        #region properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[maximumLength];
        }
        #endregion

        #region 
        public void Push(T value)
        {
            if (Size == maximumLength)
                throw new ExceededSizeException();

            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stackArray[--Size];
        }

        public T Peek()
        {
            if (Size == 0)
                throw new ExpenditureProhibitedException();

            return stackArray[Size - 1];
        }
        #endregion
    }
}