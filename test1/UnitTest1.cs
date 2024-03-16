using NUnit.Framework.Interfaces;
using plecakowy1;
using System.ComponentModel;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_CountElements()
        {
            int seed = 1;
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n, seed);
                Assert.AreEqual(n,problem.Items.Count);
            }

        }

        [TestMethod]
        public void TestMethod_IsReturnAtLeastOne()
        {
            int value = 3, weight = 2, index = 0, capacity = 10;
            
            List<Item> Items = new List<Item>();
            Item item = new Item(value, weight, index);
            Items.Add(item);

            Result ExpectedResult = new Result(Items);

            Problem problem = new Problem(1,Items);

            Assert.AreEqual(ExpectedResult,problem.Solve(capacity));
        }

        [TestMethod]
        public void TestMethod_IsReturnEmpty()
        {
            int value = 3, weight = 2, index = 0, capacity = 1;
            List<Item> Items = new List<Item>();

            Result ExpectedResult = new Result(Items);

            Item item = new Item(value, weight, index);
            Items.Add(item);

            Problem problem = new Problem(1,Items);

            Assert.AreEqual(ExpectedResult, problem.Solve(capacity));
        }

        [TestMethod]
        public void TestMethod_IsReturnExpectedResultForKnownInstance()
        {
            int capacity = 2;
            List<Item> Items = new List<Item>();
            List<Item> BestItems = new List<Item>();
            Item item0 = new Item(1, 1, 0);
            Item item1 = new Item(2, 1, 1);
            Item item2 = new Item(3, 1, 2);
            Item item3 = new Item(4, 1, 3);
            Items.Add(item0);
            Items.Add(item1);
            Items.Add(item2);
            Items.Add(item3);
            BestItems.Add(item3);
            BestItems.Add(item2);

            Problem problem = new Problem(4,Items);

            Result ExpectedResult = new Result(BestItems);

            Assert.AreEqual(ExpectedResult, problem.Solve(capacity));
        }

        [TestMethod] 
        public void TestMethod_DoesTheOrderMatter()
        {
            List<Item> Items1 = new List<Item>();
            List<Item> Items2 = new List<Item>();
            Item item0 = new Item(1, 1, 0);
            Item item1 = new Item(2, 1, 1);
            Item item2 = new Item(3, 1, 2);
            Item item3 = new Item(4, 1, 3);

            Items1.Add(item0);
            Items1.Add(item1);
            Items1.Add(item2);
            Items1.Add(item3);

            Items2.Add(item3);
            Items2.Add(item2);
            Items2.Add(item1);
            Items2.Add(item0);

            Problem Problem1 = new Problem(4, Items1);
            Problem Problem2 = new Problem(4, Items2);

            Assert.AreEqual(Problem1.Solve(5), Problem2.Solve(5));
        }

        [TestMethod]
        public void TestMethod_DoesTheSeedMatter()
        {
            int number = 10, seed1 = 1, seed2 = 2, capacity = 50;

            Problem Problem1 = new Problem(number, seed1);
            Problem Problem2 = new Problem(number, seed2);

            Assert.AreNotEqual(Problem1.Solve(capacity), Problem2.Solve(capacity));
        }

        [TestMethod]
        public void TestMethod_IsReturnNotEmpty()
        {
            int value = 3, weight = 2, index = 0, capacity = 10;
            List<Item> Items = new List<Item>();

            Item item = new Item(value, weight, index);
            Items.Add(item);

            Result ExpectedResult = new Result(Items);

            Problem problem = new Problem(1, Items);

            Assert.AreEqual(ExpectedResult, problem.Solve(capacity));
        }

        [TestMethod]
        public void TestMethod_IsReturnEmptyIfCapacityIsZero()
        {
            int value = 3, weight = 2, index = 0, capacity = 0;
            List<Item> Items = new List<Item>();

            Result ExpectedResult = new Result(Items);

            Item item = new Item(value, weight, index);
            Items.Add(item);

            Problem problem = new Problem(1, Items);

            Assert.AreEqual(ExpectedResult, problem.Solve(capacity));
        }
    }

}