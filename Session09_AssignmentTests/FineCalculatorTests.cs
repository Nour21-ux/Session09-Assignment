using Session09_Assignment;

namespace Session09_AssignmentTests
{
    public class FineCalculatorTests
    {
        private readonly FineCalculator _calculator;

        public FineCalculatorTests() 
        {
            _calculator = new FineCalculator();
        }
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            
            // Arrange
            int x = 5;
            int y = 3;
            // Act
            int result = _calculator.Add(x, y);
            // Assert
            Assert.Equal(8, result);
        }
        [Fact]
        public void Add_ShouldReturnNotEqual()
        {
           
            // Arrange
            int x = 5;
            int y = 3;
            // Act
            int result = _calculator.Add(x, y);
            // Assert
            Assert.NotEqual(3, result);
        }
        [Fact]

        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int x = 5;
            int y = 3;
            // Act
            int result = _calculator.subtract(x, y);
            // Assert
            Assert.Equal(2, result);

        }

        [Theory]
        [InlineData(2,3,6)]
        [InlineData(2, -3, -6)]
        [InlineData(2, -10, -20)]

        public void Multiply_ShouldReturnCorrectResult(int x,int y,int expected)
        {
            //Act
            int actual= _calculator.Multiply(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(2, -3, 6)]
        [InlineData(2, -10, 20)]

        public void Multiply_ShouldReturnNotEqual(int x, int y, int expected)
        {
            //Act
            int actual = _calculator.Multiply(x, y);
            //Assert
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            
            // Arrange
            int a = 12;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() =>
            {
                return _calculator.Divide(a, b);
            });
           
        }
    }
}
