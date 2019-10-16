using NUnit.Framework;
using TDD.Stack.WebApp.Models;

namespace TDD.Stack.WebApp.Tests
{
    [TestFixture]
    public class StackUnitTest
    {
        [Test]
        public void Create_Stack()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.AreEqual(0, stack.Size, "Stack Creation");
        }

        [Test]
        public void Push_Pop_Stack()
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int value = stack.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, stack.Size);
        }

        [Test]
        public void Too_Much_Pop()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Pop());
        }

        [Test]
        public void Too_Many_Push()
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Throws<ExceededSizeException>(() => stack.Push(4));
        }

        [Test]
        public void Peek_Exception()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Peek());
        }

        [Test]
        public void Peek_Element()
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            int value = stack.Peek();
            Assert.AreEqual(2, value);
            Assert.AreEqual(2, stack.Size);
        }
    }
}
