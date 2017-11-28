using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            PetiStack petiStack = new PetiStack(4);
            petiStack.Push("aaa");
            petiStack.Push("bbb");
            petiStack.Push("ccc");
            petiStack.Push("ddd");
            Console.WriteLine("Size: " + petiStack.Size);
            for(int i = 0; i<4; i++)
            {
                Console.WriteLine("Peek: " + petiStack.Peek());
                Console.WriteLine("Pop: " + petiStack.Pop());
                Console.WriteLine("FreeSpace: " + petiStack.FreeSpace());
            }
            
            Console.ReadKey();
        }
    }
}
