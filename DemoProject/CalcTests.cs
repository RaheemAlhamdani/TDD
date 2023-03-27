namespace DemoProject
{
    // Test Suite
    [TestClass]
    public class CalcTests
    {
        private Calc calc;
        [TestInitialize]
        public void Init()
        {
            calc = new Calc();
            calc.FibonacciArray(5);
        }
        // Test
        [TestMethod]
        public void Add()
        {
            // Arrange 
            var a = 1;
            var b = 2;
            var expectedResult = 3;

            // Act

            var actualResult = calc.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Divide()
        {
            // Arrange 
            var a = 4;
            var b = 2;
            var expectedResult = 2;

            // Act

            var actualResult = calc?.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            // Arrange 
            var a = 4;
            var b = 0;

            // Act
            calc?.Divide(a, b);


        }
    }
}