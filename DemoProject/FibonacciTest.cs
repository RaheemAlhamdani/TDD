namespace DemoProject
{
    [TestClass]
    public class FibonacciTest
    {
        Fibonacci? fib;

        [TestInitialize]
        public void Init()
        {
            fib = new Fibonacci();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibOfNegatives()
        {
            fib!.FibonacciRes(-1);
        }

        [TestMethod]

        public void FibOfZero()
        {
            var expected = new int[0];
            var res = fib!.FibonacciRes(0);
            CollectionAssert.AreEqual(res, expected);
        }

        [TestMethod]
        public void FibOfOne()
        {
            var expected = new int[1] { 0 };
            var res = fib!.FibonacciRes(1);
            CollectionAssert.AreEqual(res, expected);
        }

        [TestMethod]
        public void FibOfN2()
        {
            var expected = new int[2] { 0, 1 };
            var res = fib!.FibonacciRes(2);
            CollectionAssert.AreEqual(res, expected);
        }

        [TestMethod]
        public void FibOfN3()
        {
            var expected = new int[3] { 0, 1, 1 };
            var res = fib!.FibonacciRes(3);
            CollectionAssert.AreEqual(res, expected);
        }


        [TestMethod]
        public void FibOfN()
        {
            var expected = new int[4] { 0, 1, 1, 2 };
            var res = fib!.FibonacciRes(4);
            CollectionAssert.AreEqual(res, expected);
        }

        [TestMethod]
        public void FibOfN6()
        {
            var expected = new int[6] { 0, 1, 1, 2, 3, 5 };
            var res = fib!.FibonacciRes(6);
            CollectionAssert.AreEqual(res, expected);
        }

        [TestMethod]
        public void FibOfNx()
        {
            var expected = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
            var res = fib!.FibonacciRes(8);
            CollectionAssert.AreEqual(res, expected);
        }

    }

    public class Fibonacci
    {
        public Fibonacci()
        {
        }
        public int[] FibonacciRes(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (n == 0)
            {
                return new int[0];
            }
            if (n == 1)
            {
                return new int[1] { 0 };
            }
            // int number = n - 1;
            int[] Fib = new int[n];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i < n; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }

            return Fib;
        }
    }
}