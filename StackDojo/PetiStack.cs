using System;

namespace StackDojo
{
    public class PetiStack
    {
        public int Size { get; }
        object[] theMagic;
        int elementCounter = -1;

        public PetiStack(int s)
        {
            Size = s;
            theMagic = new object[Size];
        }

        public void Push(object o)
        {
            if (elementCounter == (Size - 1))
            {
                throw new StackOverflowException();
            }
            else
            {
                theMagic[++elementCounter] = o;
            }
        }

        public object Pop()
        {
            if (elementCounter == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            else
            {
                object popResult = theMagic[elementCounter];
                theMagic[elementCounter] = null;
                elementCounter--;
                return popResult;
            }
        }

        public object Peek()
        {
            if (elementCounter == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            else
            {
                return theMagic[elementCounter];
            }
        }

        public int FreeSpace()
        {
            return Size - (elementCounter+1);
        }
    }
}
