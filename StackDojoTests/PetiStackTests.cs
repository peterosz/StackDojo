using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackDojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo.Tests
{
    [TestClass()]
    public class PetiStackTests
    {
        PetiStack petiStack;

        [TestInitialize]
        public void TestSetUp()
        {
            petiStack = new PetiStack(10);
            for(int i = 0; i<10; i++)
            {
                petiStack.Push(i);
            }
        }
            

        [TestMethod()]
        public void PetiStackTest_ConstructorWithArgument4_CreatesSize4Stack()
        {
            petiStack = new PetiStack(4);
            Assert.AreEqual(4, petiStack.Size);
        }

        [TestMethod()]
        public void PushTest_()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void PopTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PeekTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FreeSpaceTest()
        {
            Assert.Fail();
        }
    }
}