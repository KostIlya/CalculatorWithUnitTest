using Calculator;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Add_7Plus4_11Returned()
        {
            // arrange
            var calc = new Calculat();
            float x = 7f;
            float y = 4f;
            float expected = 11f;

            // act
            float actual = calc.Add(x, y);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Sub_7Minus4_3Returned()
        {
            // arrange
            var calc = new Calculat();
            float x = 7f;
            float y = 4f;
            float expected = 3f;

            // act
            float actual = calc.Sub(x, y);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Mul_7Multiply4_28Returned()
        {
            // arrange
            var calc = new Calculat();
            float x = 7f;
            float y = 4f;
            float expected = 28f;

            // act
            float actual = calc.Mul(x, y);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Div_8Divide4_2Returned()
        {
            // arrange
            var calc = new Calculat();
            float x = 8f;
            float y = 4f;
            float expected = 2f;

            // act
            float actual = calc.Div(x, y);

            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Div_8Divide0__1Returned()
        {
            // arrange
            var calc = new Calculat();
            float x = 8f;
            float y = 0f;
            float expected = -1f;

            // act
            float actual = calc.Div(x, y);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}