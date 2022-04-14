using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack_Implementation;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnTrue()
        {
            var stack = new MyStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Count_PushOneItem_ReturnOne()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        public void Pop_Test()
        {
            var stack = new MyStack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        public void Peek_Test()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Peek());
        }
    }
}
