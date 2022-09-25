using LinkedListTask;
using NUnit.Framework;
using System;
using System.Xml.Schema;

namespace Tests.LinkedListTaskTests
{   
    [TestFixture]
    public class LinkedListTaskTests
    {
        private static MyLinkedList CreateRandom()
        {
            var list = new MyLinkedList();
            var rng = new Random();
            var len = rng.Next() % 1000 + 1;
            for (var i = 0; i < len; ++i)
            {
                list.Insert(rng.Next());
            }

            return list;
        }

        [Test]
        public void BigRandomIntersectTest()
        {
            var solver = new TaskSolver();
            for (var it = 0; it < 100; ++it)
            {
                var head1 = CreateRandom();
                var head2 = CreateRandom();
                var tail = CreateRandom();
                head1.End().next = tail.Begin();
                head2.End().next = tail.Begin();
                Assert.True(TaskSolver.Solve(head1, head2) == tail.Begin());
            }
        }
        
        [Test]
        public void NoIntersectionTest()
        {
            var solver = new TaskSolver();
            for (var it = 0; it < 100; ++it)
            {
                var head1 = CreateRandom();
                var head2 = CreateRandom();
                Assert.True(TaskSolver.Solve(head1, head2) == null);
            }
        }
    }
}