﻿namespace DemoProject
{
    [TestClass]
    public class FibonacciArray
    {
        Fibonacci? fib;

        [TestInitialize]
        public void Init()
        {
            fib = new Fibonacci();
        }

        [TestMethod]
        public void fibo()
        {
            Assert.AreEqual(fib, fib);
        }

    }

    public class Fibonacci
    {
        public Fibonacci()
        {

        }
    }
}