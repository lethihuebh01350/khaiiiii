using UnitTestingBasic;
namespace TestCalculatorProject
{
    public class UnitTest1
    {
        private readonly Calculator _calculator;
        public UnitTest1()
        {
            _calculator = new Calculator();
        }
        [Fact]
        public void TestAddCalculator()
        {
            double result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }
        [Fact]
        public void TestSubtractCalculator()
        {
            double result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }
    }
}