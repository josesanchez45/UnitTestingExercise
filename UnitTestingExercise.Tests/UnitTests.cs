using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(9, 10, 19, 38)]
        [InlineData(5, 5, 0, 10)]
        [InlineData(1, 10, 6, 17)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var cal1 = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = cal1.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1 , 1)]
        [InlineData(10, 1, 9)]
        [InlineData(9, 5 ,4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var sub1 = new Calculator();

            //Act
            var actual = sub1.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9,9, 81)]
        [InlineData(0, 1000000, 0)]
        [InlineData( 5, 6, 30)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multi1 = new Calculator();

            //Act
            var actual = multi1.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 9, 1 )]
        [InlineData(49, 7, 7)]
        [InlineData(30, 6, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var div1 = new Calculator();

            //Act
            var actual = div1.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
